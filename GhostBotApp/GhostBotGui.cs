using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBotApp
{
    public partial class GhostBotGui : Form
    {
        public static UserConfigOptionsModel UserConfigOptions { get; set; }

        private NotifyIcon _trayIcon;
        private ContextMenu _trayMenu;
        private Thread _ghostBotThread;

        private static bool _scanAgain = true;
    
        public GhostBotGui(UserConfigOptionsModel userConfigOptions)
        {
            UserConfigOptions = userConfigOptions;

            // Create a simple tray menu with only one item.
            _trayMenu = new ContextMenu();

            BuildTrayMenu();

            // Create a tray icon.
            _trayIcon = new NotifyIcon();
            _trayIcon.Text = "GhostBot";
            _trayIcon.Icon = new Icon(SystemIcons.Shield, 40, 40);

            // Add menu to tray icon and show it.
            _trayIcon.ContextMenu = _trayMenu;
            _trayIcon.Visible = true;
        }

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void ExecuteGhostBot(object sender, EventArgs e)
        {
            _ghostBotThread = new Thread(new ThreadStart(GhostBotThread));

            _ghostBotThread.Start();
        }

        private void PauseGhostBot(object sender, EventArgs e)
        {
            _scanAgain = false;
            BuildTrayMenu(excutingScan: false);
        }

        private void ConfigureGhostBot(object sender, EventArgs e)
        {
            _scanAgain = false;

            // open window to display config options
            var configForm = ConfigForm.GetInstance(UserConfigOptions);

            configForm.Show();
        }

        private void OnExit(object sender, EventArgs e)
        {
            _scanAgain = false;
            Application.Exit();
        }
        #endregion

        #region Private Methods

        private void GhostBotThread()
        {
            _scanAgain = true;

            BuildTrayMenu(excutingScan: true);

            while (_scanAgain)
            {
                GhostBotEngine.Execute(UserConfigOptions);
            }
        }

        private void BuildTrayMenu(bool excutingScan = false)
        {
            _trayMenu.MenuItems.Clear();

            if (excutingScan)
            {
                _trayMenu.MenuItems.Add("Pause", PauseGhostBot);
            }
            else
            {
                _trayMenu.MenuItems.Add("Start", ExecuteGhostBot);
                _trayMenu.MenuItems.Add("Configure", ConfigureGhostBot);
            }
            _trayMenu.MenuItems.Add("Exit", OnExit);
        }
        #endregion

        #region Overrides

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                _trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
        #endregion
    }
}
