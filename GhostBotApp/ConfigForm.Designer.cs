namespace GhostBotApp
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.rdTestOn = new System.Windows.Forms.RadioButton();
            this.rdTestOff = new System.Windows.Forms.RadioButton();
            this.gbTestingFlag = new System.Windows.Forms.GroupBox();
            this.txtResourcePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnResourcePath = new System.Windows.Forms.Button();
            this.gbResourceLocation = new System.Windows.Forms.GroupBox();
            this.gbScanOptions = new System.Windows.Forms.GroupBox();
            this.lblIdleThreshold = new System.Windows.Forms.Label();
            this.lblPauseBetweenScan = new System.Windows.Forms.Label();
            this.numPauseTime = new System.Windows.Forms.NumericUpDown();
            this.numIdleThreshold = new System.Windows.Forms.NumericUpDown();
            this.gbSlackUrlInfo = new System.Windows.Forms.GroupBox();
            this.lblSlackChannel = new System.Windows.Forms.Label();
            this.lblSlackBaseUrl = new System.Windows.Forms.Label();
            this.txtSlackChannel = new System.Windows.Forms.TextBox();
            this.txtSlackBaseUrl = new System.Windows.Forms.TextBox();
            this.gbGhostBotMessage = new System.Windows.Forms.GroupBox();
            this.lblSlackFormmating2 = new System.Windows.Forms.Label();
            this.lblFormattingExplanation = new System.Windows.Forms.Label();
            this.txtGhostBotMessage = new System.Windows.Forms.TextBox();
            this.gbMenuLocation = new System.Windows.Forms.GroupBox();
            this.rdMenuRight = new System.Windows.Forms.RadioButton();
            this.rdMenuLeft = new System.Windows.Forms.RadioButton();
            this.rdMenuTop = new System.Windows.Forms.RadioButton();
            this.rdMenuBottom = new System.Windows.Forms.RadioButton();
            this.txtSingleScreenLocation = new System.Windows.Forms.TextBox();
            this.txtMultiScreenLocation = new System.Windows.Forms.TextBox();
            this.lblSingleScreenLocation = new System.Windows.Forms.Label();
            this.lblMultiScreenLocation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbTestingFlag.SuspendLayout();
            this.gbResourceLocation.SuspendLayout();
            this.gbScanOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPauseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdleThreshold)).BeginInit();
            this.gbSlackUrlInfo.SuspendLayout();
            this.gbGhostBotMessage.SuspendLayout();
            this.gbMenuLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(656, 715);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdTestOn
            // 
            this.rdTestOn.AutoSize = true;
            this.rdTestOn.Location = new System.Drawing.Point(17, 29);
            this.rdTestOn.Name = "rdTestOn";
            this.rdTestOn.Size = new System.Drawing.Size(48, 21);
            this.rdTestOn.TabIndex = 2;
            this.rdTestOn.Text = "On";
            this.rdTestOn.UseVisualStyleBackColor = true;
            // 
            // rdTestOff
            // 
            this.rdTestOff.AutoSize = true;
            this.rdTestOff.Checked = true;
            this.rdTestOff.Location = new System.Drawing.Point(17, 58);
            this.rdTestOff.Name = "rdTestOff";
            this.rdTestOff.Size = new System.Drawing.Size(48, 21);
            this.rdTestOff.TabIndex = 3;
            this.rdTestOff.TabStop = true;
            this.rdTestOff.Text = "Off";
            this.rdTestOff.UseVisualStyleBackColor = true;
            // 
            // gbTestingFlag
            // 
            this.gbTestingFlag.Controls.Add(this.rdTestOn);
            this.gbTestingFlag.Controls.Add(this.rdTestOff);
            this.gbTestingFlag.Location = new System.Drawing.Point(534, 645);
            this.gbTestingFlag.Name = "gbTestingFlag";
            this.gbTestingFlag.Size = new System.Drawing.Size(107, 99);
            this.gbTestingFlag.TabIndex = 4;
            this.gbTestingFlag.TabStop = false;
            this.gbTestingFlag.Text = "Testing Flag";
            // 
            // txtResourcePath
            // 
            this.txtResourcePath.Location = new System.Drawing.Point(62, 65);
            this.txtResourcePath.Name = "txtResourcePath";
            this.txtResourcePath.ReadOnly = true;
            this.txtResourcePath.Size = new System.Drawing.Size(588, 22);
            this.txtResourcePath.TabIndex = 5;
            // 
            // btnResourcePath
            // 
            this.btnResourcePath.Location = new System.Drawing.Point(656, 63);
            this.btnResourcePath.Name = "btnResourcePath";
            this.btnResourcePath.Size = new System.Drawing.Size(139, 28);
            this.btnResourcePath.TabIndex = 6;
            this.btnResourcePath.Text = "Browse";
            this.btnResourcePath.UseVisualStyleBackColor = true;
            this.btnResourcePath.Click += new System.EventHandler(this.btnResourcePath_Click);
            // 
            // gbResourceLocation
            // 
            this.gbResourceLocation.Controls.Add(this.lblMultiScreenLocation);
            this.gbResourceLocation.Controls.Add(this.lblSingleScreenLocation);
            this.gbResourceLocation.Controls.Add(this.txtMultiScreenLocation);
            this.gbResourceLocation.Controls.Add(this.txtSingleScreenLocation);
            this.gbResourceLocation.Location = new System.Drawing.Point(22, 23);
            this.gbResourceLocation.Name = "gbResourceLocation";
            this.gbResourceLocation.Size = new System.Drawing.Size(828, 143);
            this.gbResourceLocation.TabIndex = 7;
            this.gbResourceLocation.TabStop = false;
            this.gbResourceLocation.Text = "Resource Location";
            // 
            // gbScanOptions
            // 
            this.gbScanOptions.Controls.Add(this.lblIdleThreshold);
            this.gbScanOptions.Controls.Add(this.lblPauseBetweenScan);
            this.gbScanOptions.Controls.Add(this.numPauseTime);
            this.gbScanOptions.Controls.Add(this.numIdleThreshold);
            this.gbScanOptions.Location = new System.Drawing.Point(534, 401);
            this.gbScanOptions.Name = "gbScanOptions";
            this.gbScanOptions.Size = new System.Drawing.Size(316, 221);
            this.gbScanOptions.TabIndex = 8;
            this.gbScanOptions.TabStop = false;
            this.gbScanOptions.Text = "Processing Options";
            // 
            // lblIdleThreshold
            // 
            this.lblIdleThreshold.AutoSize = true;
            this.lblIdleThreshold.Location = new System.Drawing.Point(15, 127);
            this.lblIdleThreshold.Name = "lblIdleThreshold";
            this.lblIdleThreshold.Size = new System.Drawing.Size(217, 17);
            this.lblIdleThreshold.TabIndex = 3;
            this.lblIdleThreshold.Text = "Time to consider Idle in Seconds:";
            // 
            // lblPauseBetweenScan
            // 
            this.lblPauseBetweenScan.AutoSize = true;
            this.lblPauseBetweenScan.Location = new System.Drawing.Point(12, 41);
            this.lblPauseBetweenScan.Name = "lblPauseBetweenScan";
            this.lblPauseBetweenScan.Size = new System.Drawing.Size(277, 17);
            this.lblPauseBetweenScan.TabIndex = 2;
            this.lblPauseBetweenScan.Text = "Time to Pause between Scans in Seconds:";
            // 
            // numPauseTime
            // 
            this.numPauseTime.Location = new System.Drawing.Point(96, 70);
            this.numPauseTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPauseTime.Name = "numPauseTime";
            this.numPauseTime.Size = new System.Drawing.Size(120, 22);
            this.numPauseTime.TabIndex = 1;
            this.numPauseTime.Tag = "";
            // 
            // numIdleThreshold
            // 
            this.numIdleThreshold.Location = new System.Drawing.Point(96, 158);
            this.numIdleThreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIdleThreshold.Name = "numIdleThreshold";
            this.numIdleThreshold.Size = new System.Drawing.Size(120, 22);
            this.numIdleThreshold.TabIndex = 1;
            this.numIdleThreshold.Tag = "";
            // 
            // gbSlackUrlInfo
            // 
            this.gbSlackUrlInfo.Controls.Add(this.lblSlackChannel);
            this.gbSlackUrlInfo.Controls.Add(this.lblSlackBaseUrl);
            this.gbSlackUrlInfo.Controls.Add(this.txtSlackChannel);
            this.gbSlackUrlInfo.Controls.Add(this.txtSlackBaseUrl);
            this.gbSlackUrlInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSlackUrlInfo.Location = new System.Drawing.Point(251, 186);
            this.gbSlackUrlInfo.Name = "gbSlackUrlInfo";
            this.gbSlackUrlInfo.Size = new System.Drawing.Size(599, 193);
            this.gbSlackUrlInfo.TabIndex = 9;
            this.gbSlackUrlInfo.TabStop = false;
            this.gbSlackUrlInfo.Text = "Slack URL Info";
            // 
            // lblSlackChannel
            // 
            this.lblSlackChannel.AutoSize = true;
            this.lblSlackChannel.Location = new System.Drawing.Point(22, 119);
            this.lblSlackChannel.Name = "lblSlackChannel";
            this.lblSlackChannel.Size = new System.Drawing.Size(102, 17);
            this.lblSlackChannel.TabIndex = 1;
            this.lblSlackChannel.Text = "Slack Channel:";
            // 
            // lblSlackBaseUrl
            // 
            this.lblSlackBaseUrl.AutoSize = true;
            this.lblSlackBaseUrl.Location = new System.Drawing.Point(17, 55);
            this.lblSlackBaseUrl.Name = "lblSlackBaseUrl";
            this.lblSlackBaseUrl.Size = new System.Drawing.Size(114, 17);
            this.lblSlackBaseUrl.TabIndex = 1;
            this.lblSlackBaseUrl.Text = "Slack Base URL:";
            // 
            // txtSlackChannel
            // 
            this.txtSlackChannel.Location = new System.Drawing.Point(140, 116);
            this.txtSlackChannel.Name = "txtSlackChannel";
            this.txtSlackChannel.Size = new System.Drawing.Size(417, 22);
            this.txtSlackChannel.TabIndex = 0;
            // 
            // txtSlackBaseUrl
            // 
            this.txtSlackBaseUrl.Location = new System.Drawing.Point(140, 52);
            this.txtSlackBaseUrl.Name = "txtSlackBaseUrl";
            this.txtSlackBaseUrl.Size = new System.Drawing.Size(417, 22);
            this.txtSlackBaseUrl.TabIndex = 0;
            // 
            // gbGhostBotMessage
            // 
            this.gbGhostBotMessage.Controls.Add(this.lblSlackFormmating2);
            this.gbGhostBotMessage.Controls.Add(this.lblFormattingExplanation);
            this.gbGhostBotMessage.Controls.Add(this.txtGhostBotMessage);
            this.gbGhostBotMessage.Location = new System.Drawing.Point(22, 401);
            this.gbGhostBotMessage.Name = "gbGhostBotMessage";
            this.gbGhostBotMessage.Size = new System.Drawing.Size(483, 221);
            this.gbGhostBotMessage.TabIndex = 8;
            this.gbGhostBotMessage.TabStop = false;
            this.gbGhostBotMessage.Text = "GhostBot Message";
            // 
            // lblSlackFormmating2
            // 
            this.lblSlackFormmating2.AutoSize = true;
            this.lblSlackFormmating2.Location = new System.Drawing.Point(207, 178);
            this.lblSlackFormmating2.Name = "lblSlackFormmating2";
            this.lblSlackFormmating2.Size = new System.Drawing.Size(242, 17);
            this.lblSlackFormmating2.TabIndex = 2;
            this.lblSlackFormmating2.Text = "``preformatted``   >quote   :emoticon:";
            // 
            // lblFormattingExplanation
            // 
            this.lblFormattingExplanation.AutoSize = true;
            this.lblFormattingExplanation.Location = new System.Drawing.Point(32, 157);
            this.lblFormattingExplanation.Name = "lblFormattingExplanation";
            this.lblFormattingExplanation.Size = new System.Drawing.Size(405, 17);
            this.lblFormattingExplanation.TabIndex = 1;
            this.lblFormattingExplanation.Text = "Slack Message Formatting:   *bold*   _italics_   ~strike~   `code`";
            // 
            // txtGhostBotMessage
            // 
            this.txtGhostBotMessage.Location = new System.Drawing.Point(32, 36);
            this.txtGhostBotMessage.Multiline = true;
            this.txtGhostBotMessage.Name = "txtGhostBotMessage";
            this.txtGhostBotMessage.Size = new System.Drawing.Size(415, 96);
            this.txtGhostBotMessage.TabIndex = 0;
            // 
            // gbMenuLocation
            // 
            this.gbMenuLocation.Controls.Add(this.rdMenuRight);
            this.gbMenuLocation.Controls.Add(this.rdMenuLeft);
            this.gbMenuLocation.Controls.Add(this.rdMenuTop);
            this.gbMenuLocation.Controls.Add(this.rdMenuBottom);
            this.gbMenuLocation.Location = new System.Drawing.Point(22, 186);
            this.gbMenuLocation.Name = "gbMenuLocation";
            this.gbMenuLocation.Size = new System.Drawing.Size(202, 193);
            this.gbMenuLocation.TabIndex = 10;
            this.gbMenuLocation.TabStop = false;
            this.gbMenuLocation.Text = "Start Menu Location";
            // 
            // rdMenuRight
            // 
            this.rdMenuRight.AutoSize = true;
            this.rdMenuRight.Location = new System.Drawing.Point(32, 128);
            this.rdMenuRight.Name = "rdMenuRight";
            this.rdMenuRight.Size = new System.Drawing.Size(62, 21);
            this.rdMenuRight.TabIndex = 0;
            this.rdMenuRight.Text = "Right";
            this.rdMenuRight.UseVisualStyleBackColor = true;
            // 
            // rdMenuLeft
            // 
            this.rdMenuLeft.AutoSize = true;
            this.rdMenuLeft.Location = new System.Drawing.Point(32, 101);
            this.rdMenuLeft.Name = "rdMenuLeft";
            this.rdMenuLeft.Size = new System.Drawing.Size(53, 21);
            this.rdMenuLeft.TabIndex = 0;
            this.rdMenuLeft.Text = "Left";
            this.rdMenuLeft.UseVisualStyleBackColor = true;
            // 
            // rdMenuTop
            // 
            this.rdMenuTop.AutoSize = true;
            this.rdMenuTop.Location = new System.Drawing.Point(32, 74);
            this.rdMenuTop.Name = "rdMenuTop";
            this.rdMenuTop.Size = new System.Drawing.Size(54, 21);
            this.rdMenuTop.TabIndex = 0;
            this.rdMenuTop.Text = "Top";
            this.rdMenuTop.UseVisualStyleBackColor = true;
            // 
            // rdMenuBottom
            // 
            this.rdMenuBottom.AutoSize = true;
            this.rdMenuBottom.Checked = true;
            this.rdMenuBottom.Location = new System.Drawing.Point(32, 47);
            this.rdMenuBottom.Name = "rdMenuBottom";
            this.rdMenuBottom.Size = new System.Drawing.Size(73, 21);
            this.rdMenuBottom.TabIndex = 0;
            this.rdMenuBottom.TabStop = true;
            this.rdMenuBottom.Text = "Bottom";
            this.rdMenuBottom.UseVisualStyleBackColor = true;
            // 
            // txtSingleScreenLocation
            // 
            this.txtSingleScreenLocation.Location = new System.Drawing.Point(146, 79);
            this.txtSingleScreenLocation.Name = "txtSingleScreenLocation";
            this.txtSingleScreenLocation.ReadOnly = true;
            this.txtSingleScreenLocation.Size = new System.Drawing.Size(627, 22);
            this.txtSingleScreenLocation.TabIndex = 0;
            // 
            // txtMultiScreenLocation
            // 
            this.txtMultiScreenLocation.Location = new System.Drawing.Point(155, 106);
            this.txtMultiScreenLocation.Name = "txtMultiScreenLocation";
            this.txtMultiScreenLocation.ReadOnly = true;
            this.txtMultiScreenLocation.Size = new System.Drawing.Size(618, 22);
            this.txtMultiScreenLocation.TabIndex = 0;
            // 
            // lblSingleScreenLocation
            // 
            this.lblSingleScreenLocation.AutoSize = true;
            this.lblSingleScreenLocation.Location = new System.Drawing.Point(40, 82);
            this.lblSingleScreenLocation.Name = "lblSingleScreenLocation";
            this.lblSingleScreenLocation.Size = new System.Drawing.Size(100, 17);
            this.lblSingleScreenLocation.TabIndex = 1;
            this.lblSingleScreenLocation.Text = "Single Screen:";
            // 
            // lblMultiScreenLocation
            // 
            this.lblMultiScreenLocation.AutoSize = true;
            this.lblMultiScreenLocation.Location = new System.Drawing.Point(40, 109);
            this.lblMultiScreenLocation.Name = "lblMultiScreenLocation";
            this.lblMultiScreenLocation.Size = new System.Drawing.Size(109, 17);
            this.lblMultiScreenLocation.TabIndex = 1;
            this.lblMultiScreenLocation.Text = "Multiple Screen:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(748, 715);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 764);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMenuLocation);
            this.Controls.Add(this.gbSlackUrlInfo);
            this.Controls.Add(this.gbGhostBotMessage);
            this.Controls.Add(this.btnResourcePath);
            this.Controls.Add(this.txtResourcePath);
            this.Controls.Add(this.gbTestingFlag);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbResourceLocation);
            this.Controls.Add(this.gbScanOptions);
            this.Name = "ConfigForm";
            this.Text = "GhostBot Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.gbTestingFlag.ResumeLayout(false);
            this.gbTestingFlag.PerformLayout();
            this.gbResourceLocation.ResumeLayout(false);
            this.gbResourceLocation.PerformLayout();
            this.gbScanOptions.ResumeLayout(false);
            this.gbScanOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPauseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdleThreshold)).EndInit();
            this.gbSlackUrlInfo.ResumeLayout(false);
            this.gbSlackUrlInfo.PerformLayout();
            this.gbGhostBotMessage.ResumeLayout(false);
            this.gbGhostBotMessage.PerformLayout();
            this.gbMenuLocation.ResumeLayout(false);
            this.gbMenuLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdTestOn;
        private System.Windows.Forms.RadioButton rdTestOff;
        private System.Windows.Forms.GroupBox gbTestingFlag;
        private System.Windows.Forms.TextBox txtResourcePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnResourcePath;
        private System.Windows.Forms.GroupBox gbResourceLocation;
        private System.Windows.Forms.GroupBox gbScanOptions;
        private System.Windows.Forms.GroupBox gbSlackUrlInfo;
        private System.Windows.Forms.Label lblSlackChannel;
        private System.Windows.Forms.Label lblSlackBaseUrl;
        private System.Windows.Forms.TextBox txtSlackChannel;
        private System.Windows.Forms.TextBox txtSlackBaseUrl;
        private System.Windows.Forms.GroupBox gbGhostBotMessage;
        private System.Windows.Forms.Label lblSlackFormmating2;
        private System.Windows.Forms.Label lblFormattingExplanation;
        private System.Windows.Forms.TextBox txtGhostBotMessage;
        private System.Windows.Forms.NumericUpDown numIdleThreshold;
        private System.Windows.Forms.Label lblIdleThreshold;
        private System.Windows.Forms.Label lblPauseBetweenScan;
        private System.Windows.Forms.NumericUpDown numPauseTime;
        private System.Windows.Forms.GroupBox gbMenuLocation;
        private System.Windows.Forms.RadioButton rdMenuRight;
        private System.Windows.Forms.RadioButton rdMenuLeft;
        private System.Windows.Forms.RadioButton rdMenuTop;
        private System.Windows.Forms.RadioButton rdMenuBottom;
        private System.Windows.Forms.Label lblMultiScreenLocation;
        private System.Windows.Forms.Label lblSingleScreenLocation;
        private System.Windows.Forms.TextBox txtMultiScreenLocation;
        private System.Windows.Forms.TextBox txtSingleScreenLocation;
        private System.Windows.Forms.Button btnCancel;
    }
}