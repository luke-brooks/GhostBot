using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Windows.Forms;

namespace GhostBotApp
{
    public static class GhostBotEngine
    {
        public static void Execute(UserConfigOptionsModel userConfigOptions)
        {
            var ioService = new IoDetectionService(userConfigOptions);
            var slackService = new SlackApiService(userConfigOptions);

            Thread.Sleep(userConfigOptions.PauseTimeBetweenScansSec * 1000);

            var userIsIdle = ioService.CheckUserIdleStatus();
            var receivedIm = false;

            if (userIsIdle)
            {
                ioService.WiggleMouse();

                receivedIm = ioService.AnalyzeScreen();

                if (receivedIm)
                {
                    slackService.SendMessage(String.Empty);
                }
                else if (userConfigOptions.TestingFlag.ToLower() == "true".ToLower())
                {
                    slackService.SendMessage("*TEST MESSAGE*");
                }
            }
        }
    }
}
