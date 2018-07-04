using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace GhostBotApp
{
    public class IoDetectionService
    {
        public static UserConfigOptionsModel UserConfigOptions { get; set; }
        
        public IoDetectionService(UserConfigOptionsModel userConfigOptions)
        {
            UserConfigOptions = userConfigOptions;
        }

        #region Public Methods

        public bool CheckUserIdleStatus()
        {
            var userIsIdle = false;

            var idleSeconds = TimeSpan.FromTicks(GetLastUserInput.GetIdleTickCount()).TotalSeconds * 10000; // multiply by 10,000 to adjust the low level data to C# data type

            if (idleSeconds > UserConfigOptions.IdleThresholdSec)
            {
                userIsIdle = true;
            }

            return userIsIdle;
        }

        public void WiggleMouse()
        {
            Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y);
            Thread.Sleep(500);
            Cursor.Position = new Point(Cursor.Position.X - 10, Cursor.Position.Y);
        }

        public bool AnalyzeScreen()
        {
            var screenshot = TakeScreenshot();
            var response = false;

            var location = new Point(); // not used right now but can be used to move the mouse to the identified bitmap

            var bitmaps = LoadBitmapResources();

            if (bitmaps.Any())
            {
                response = FindBitmapInImage(bitmaps, screenshot, out location);
            }

            return response;
        }

        #endregion

        #region Private Methods

        private Bitmap TakeScreenshot()
        {
            var screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            var g = Graphics.FromImage(screenshot);

            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            return screenshot;
        }

        private List<Bitmap> LoadBitmapResources()
        {
            var bitmaps = new List<Bitmap>();

            var singleScreenDir = String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.SingleScreenLocation);
            var multiScreenDir = String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.MultiScreenLocation);
            ConfigService.CheckResourceDirectoryExists(singleScreenDir);
            ConfigService.CheckResourceDirectoryExists(multiScreenDir);

            var currentResourceDir = singleScreenDir;

            if (Screen.AllScreens.Count() > 1)
            {
                currentResourceDir = multiScreenDir;
            }

            var files = Directory.GetFiles(currentResourceDir, String.Format("*.bmp", UserConfigOptions.ResourceLocation));

            foreach (var f in files)
            {
                bitmaps.Add(new Bitmap(f));
            }

            return bitmaps;
        }

        private bool FindBitmapInImage(List<Bitmap> needles, Bitmap haystack, out Point location)
        {
            var smallestWidth = needles.Min(x => x.Width);
            var smallestHeight = needles.Min(x => x.Height);

            #region Determine Start Menu Location
            // check only the quarter of the screen that has the Start Menu to reduce processing time
            int startingX = 0;
            int startingY = 0;
            int maxX = haystack.Width - smallestWidth;
            int maxY = haystack.Height - smallestHeight;

            switch (UserConfigOptions.MenuLocation)
            {
                case "bottom":
                    startingY = Convert.ToInt32(haystack.Height * .75);
                    break;
                case "top":
                    maxY = Convert.ToInt32(haystack.Height * .25);
                    break;
                case "left":
                    maxX = Convert.ToInt32(haystack.Width * .25);
                    break;
                case "right":
                    maxX = Convert.ToInt32(haystack.Width * .75);
                    break;
                default:
                    break;
            }
            #endregion

            // The X and Y of the outer loops represent the coordinates on the Screenshot object
            for (int outerX = startingX; outerX < maxX; outerX++)
            {
                for (int outerY = startingY; outerY < maxY; outerY++)
                {
                    // Iterate through each bitmap that we are searching for
                    foreach (var n in needles)
                    {
                        // The X and Y on the inner loops represent the coordinates on the bitmap that we are trying to find in the Screenshot
                        for (int innerX = 0; innerX < n.Width; innerX++)
                        {
                            for (int innerY = 0; innerY < n.Height; innerY++)
                            {
                                Color cNeedle = n.GetPixel(innerX, innerY);
                                Color cHaystack = haystack.GetPixel(innerX + outerX, innerY + outerY);

                                // We compare the color of the pixel in the Screenshot with the pixel in the bitmap we are searching for
                                if (cNeedle.R != cHaystack.R || cNeedle.G != cHaystack.G || cNeedle.B != cHaystack.B)
                                {
                                    // Stop examining the current bitmap once a single pixel doesn't match
                                    goto notFound;
                                }
                            }
                        }

                        // Return true when one of the bitmaps have been matched on the Screenshot
                        location = new Point(outerX, outerY);
                        return true;

                        notFound:
                            continue; 
                    }
                }
            }

            // Return an empty point and false when no bitmaps have matched with the Screenshot
            location = Point.Empty;
            return false;
        }
        #endregion
    }
}
