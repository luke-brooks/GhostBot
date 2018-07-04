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

namespace GhostBotApp
{
    public partial class ConfigForm : Form
    {
        public static UserConfigOptionsModel UserConfigOptions { get; set; }

        private static ConfigForm _configForm;

        private ConfigForm(UserConfigOptionsModel userConfigOptions)
        {
            UserConfigOptions = userConfigOptions;

            InitializeComponent();
        }

        public static ConfigForm GetInstance(UserConfigOptionsModel userConfigOptions)
        {
            if (_configForm == null)
            {
                _configForm = new ConfigForm(userConfigOptions);
                _configForm.FormClosed += delegate { _configForm = null; }; // When the form gets closed: run the code in the delegate
            }

            _configForm.BringToFront();

            return _configForm;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 2500;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.gbTestingFlag, "Allows a Test Message to be sent when there is no new IM.");
            toolTip1.SetToolTip(this.rdTestOn, "Allows a Test Message to be sent when there is no new IM.");
            toolTip1.SetToolTip(this.rdTestOff, "Allows a Test Message to be sent when there is no new IM.");

            #region Load Config Data
            // Load Resource Info
            txtResourcePath.Text = UserConfigOptions.ResourceLocation;
            txtSingleScreenLocation.Text = String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.SingleScreenLocation);
            txtMultiScreenLocation.Text = String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.MultiScreenLocation);

            // Load Start Menu Info
            switch (UserConfigOptions.MenuLocation)
            {
                case "bottom":
                    rdMenuBottom.Checked = true;
                    break;
                case "top":
                    rdMenuTop.Checked = true;
                    break;
                case "left":
                    rdMenuLeft.Checked = true;
                    break;
                case "right":
                    rdMenuRight.Checked = true;
                    break;
                default:
                    break;
            }

            // Load Slack Info
            txtSlackBaseUrl.Text = UserConfigOptions.SlackBaseUrl;
            txtSlackChannel.Text = UserConfigOptions.SlackChannel;

            // Load GhostBot Message
            txtGhostBotMessage.Text = UserConfigOptions.GhostBotMessage;

            // Load Processing Options
            numPauseTime.Value = UserConfigOptions.PauseTimeBetweenScansSec;
            numIdleThreshold.Value = UserConfigOptions.IdleThresholdSec;

            // Load Testing Info
            if (UserConfigOptions.TestingFlag.ToLower() == "false")
            {
                rdTestOff.Checked = true;
            }
            else
            {
                rdTestOn.Checked = true;
            }
            #endregion
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _configForm = null;
        }

        #region User Events

        private void btnResourcePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = UserConfigOptions.ResourceLocation;
            folderBrowserDialog1.ShowDialog();

            txtResourcePath.Text = folderBrowserDialog1.SelectedPath;
            txtSingleScreenLocation.Text = String.Format("{0}\\{1}", folderBrowserDialog1.SelectedPath, UserConfigOptions.SingleScreenLocation);
            txtMultiScreenLocation.Text = String.Format("{0}\\{1}", folderBrowserDialog1.SelectedPath, UserConfigOptions.MultiScreenLocation);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateConfigInfoObject();

            ConfigService.CheckResourceDirectoryExists(String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.SingleScreenLocation));
            ConfigService.CheckResourceDirectoryExists(String.Format("{0}\\{1}", UserConfigOptions.ResourceLocation, UserConfigOptions.MultiScreenLocation));

            ConfigService.SaveUserConfigOptions(UserConfigOptions);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Private Methods

        private void UpdateConfigInfoObject()
        {
            UserConfigOptions.ResourceLocation = txtResourcePath.Text;

            if (rdMenuBottom.Checked)
            {
                UserConfigOptions.MenuLocation = "bottom";
            }
            if (rdMenuTop.Checked)
            {
                UserConfigOptions.MenuLocation = "top";
            }
            if (rdMenuLeft.Checked)
            {
                UserConfigOptions.MenuLocation = "left";
            }
            if (rdMenuRight.Checked)
            {
                UserConfigOptions.MenuLocation = "right";
            }

            UserConfigOptions.SlackBaseUrl = txtSlackBaseUrl.Text;
            UserConfigOptions.SlackChannel = txtSlackChannel.Text;

            UserConfigOptions.GhostBotMessage = txtGhostBotMessage.Text;

            UserConfigOptions.PauseTimeBetweenScansSec = Decimal.ToInt32(numPauseTime.Value);
            UserConfigOptions.IdleThresholdSec = Decimal.ToInt32(numIdleThreshold.Value);

            if (rdTestOn.Checked)
            {
                UserConfigOptions.TestingFlag = "true";
            }
            if (rdTestOff.Checked)
            {
                UserConfigOptions.TestingFlag = "false";
            }
        }
        #endregion
    }
}
