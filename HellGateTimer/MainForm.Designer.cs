namespace HellGateTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTimerStart3m = new System.Windows.Forms.Button();
            this.buttonTimerStart6m = new System.Windows.Forms.Button();
            this.buttonTimerReset = new System.Windows.Forms.Button();
            this.labelCurrentTimeDisplay = new System.Windows.Forms.Label();
            this.labelLeftTime = new System.Windows.Forms.Label();
            this.labelTimeStampDisplay = new System.Windows.Forms.Label();
            this.labelTimeStamp = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonTimerStart10m = new System.Windows.Forms.Button();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.checkBoxAllwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxMuteVolume = new System.Windows.Forms.CheckBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTimerStart3m
            // 
            this.buttonTimerStart3m.Location = new System.Drawing.Point(6, 6);
            this.buttonTimerStart3m.Name = "buttonTimerStart3m";
            this.buttonTimerStart3m.Size = new System.Drawing.Size(141, 23);
            this.buttonTimerStart3m.TabIndex = 0;
            this.buttonTimerStart3m.Tag = "3";
            this.buttonTimerStart3m.Text = "3분 타이머 시작";
            this.buttonTimerStart3m.UseVisualStyleBackColor = true;
            this.buttonTimerStart3m.Click += new System.EventHandler(this.TimerStart);
            // 
            // buttonTimerStart6m
            // 
            this.buttonTimerStart6m.Location = new System.Drawing.Point(7, 35);
            this.buttonTimerStart6m.Name = "buttonTimerStart6m";
            this.buttonTimerStart6m.Size = new System.Drawing.Size(140, 23);
            this.buttonTimerStart6m.TabIndex = 1;
            this.buttonTimerStart6m.Tag = "6";
            this.buttonTimerStart6m.Text = "6분 타이머 시작";
            this.buttonTimerStart6m.UseVisualStyleBackColor = true;
            this.buttonTimerStart6m.Click += new System.EventHandler(this.TimerStart);
            // 
            // buttonTimerReset
            // 
            this.buttonTimerReset.Location = new System.Drawing.Point(7, 93);
            this.buttonTimerReset.Name = "buttonTimerReset";
            this.buttonTimerReset.Size = new System.Drawing.Size(140, 23);
            this.buttonTimerReset.TabIndex = 2;
            this.buttonTimerReset.Text = "리셋";
            this.buttonTimerReset.UseVisualStyleBackColor = true;
            this.buttonTimerReset.Click += new System.EventHandler(this.TimerReset);
            // 
            // labelCurrentTimeDisplay
            // 
            this.labelCurrentTimeDisplay.AutoSize = true;
            this.labelCurrentTimeDisplay.Location = new System.Drawing.Point(5, 119);
            this.labelCurrentTimeDisplay.Name = "labelCurrentTimeDisplay";
            this.labelCurrentTimeDisplay.Size = new System.Drawing.Size(65, 12);
            this.labelCurrentTimeDisplay.TabIndex = 3;
            this.labelCurrentTimeDisplay.Text = "남은 시간 :";
            // 
            // labelLeftTime
            // 
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.Location = new System.Drawing.Point(76, 119);
            this.labelLeftTime.Name = "labelLeftTime";
            this.labelLeftTime.Size = new System.Drawing.Size(0, 12);
            this.labelLeftTime.TabIndex = 4;
            // 
            // labelTimeStampDisplay
            // 
            this.labelTimeStampDisplay.AutoSize = true;
            this.labelTimeStampDisplay.Location = new System.Drawing.Point(1, 141);
            this.labelTimeStampDisplay.Name = "labelTimeStampDisplay";
            this.labelTimeStampDisplay.Size = new System.Drawing.Size(82, 12);
            this.labelTimeStampDisplay.TabIndex = 6;
            this.labelTimeStampDisplay.Text = "TimeStamp : ";
            // 
            // labelTimeStamp
            // 
            this.labelTimeStamp.AutoSize = true;
            this.labelTimeStamp.Location = new System.Drawing.Point(89, 141);
            this.labelTimeStamp.Name = "labelTimeStamp";
            this.labelTimeStamp.Size = new System.Drawing.Size(0, 12);
            this.labelTimeStamp.TabIndex = 7;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageSetting);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(161, 184);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.buttonTimerStart10m);
            this.tabPageMain.Controls.Add(this.buttonTimerStart3m);
            this.tabPageMain.Controls.Add(this.labelTimeStamp);
            this.tabPageMain.Controls.Add(this.buttonTimerStart6m);
            this.tabPageMain.Controls.Add(this.labelTimeStampDisplay);
            this.tabPageMain.Controls.Add(this.buttonTimerReset);
            this.tabPageMain.Controls.Add(this.labelLeftTime);
            this.tabPageMain.Controls.Add(this.labelCurrentTimeDisplay);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(153, 158);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "메인";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // buttonTimerStart10m
            // 
            this.buttonTimerStart10m.Location = new System.Drawing.Point(6, 64);
            this.buttonTimerStart10m.Name = "buttonTimerStart10m";
            this.buttonTimerStart10m.Size = new System.Drawing.Size(140, 23);
            this.buttonTimerStart10m.TabIndex = 8;
            this.buttonTimerStart10m.Tag = "10";
            this.buttonTimerStart10m.Text = "10분 타이머 시작";
            this.buttonTimerStart10m.UseVisualStyleBackColor = true;
            this.buttonTimerStart10m.Click += new System.EventHandler(this.TimerStart);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.checkBoxAllwaysOnTop);
            this.tabPageSetting.Controls.Add(this.checkBoxMuteVolume);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(153, 177);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "설정";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllwaysOnTop
            // 
            this.checkBoxAllwaysOnTop.AutoSize = true;
            this.checkBoxAllwaysOnTop.Location = new System.Drawing.Point(3, 28);
            this.checkBoxAllwaysOnTop.Name = "checkBoxAllwaysOnTop";
            this.checkBoxAllwaysOnTop.Size = new System.Drawing.Size(64, 16);
            this.checkBoxAllwaysOnTop.TabIndex = 1;
            this.checkBoxAllwaysOnTop.Text = "항상 위";
            this.checkBoxAllwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBoxAllwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBoxAllwaysOnTop_CheckedChanged);
            // 
            // checkBoxMuteVolume
            // 
            this.checkBoxMuteVolume.AutoSize = true;
            this.checkBoxMuteVolume.Location = new System.Drawing.Point(3, 6);
            this.checkBoxMuteVolume.Name = "checkBoxMuteVolume";
            this.checkBoxMuteVolume.Size = new System.Drawing.Size(60, 16);
            this.checkBoxMuteVolume.TabIndex = 0;
            this.checkBoxMuteVolume.Text = "음소거";
            this.checkBoxMuteVolume.UseVisualStyleBackColor = true;
            this.checkBoxMuteVolume.CheckedChanged += new System.EventHandler(this.checkBoxMuteVolume_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 184);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "HGTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTimerStart3m;
        private System.Windows.Forms.Button buttonTimerStart6m;
        private System.Windows.Forms.Button buttonTimerReset;
        private System.Windows.Forms.Label labelCurrentTimeDisplay;
        private System.Windows.Forms.Label labelLeftTime;
        private System.Windows.Forms.Label labelTimeStampDisplay;
        private System.Windows.Forms.Label labelTimeStamp;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.CheckBox checkBoxAllwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxMuteVolume;
        private System.Windows.Forms.Button buttonTimerStart10m;
    }
}

