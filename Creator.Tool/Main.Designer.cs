namespace Creator.Tool
{
    partial class Main
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
            this.groupBoxCom = new System.Windows.Forms.GroupBox();
            this.buttonComRefresh = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.buttonDispense = new System.Windows.Forms.Button();
            this.groupBoxChecking = new System.Windows.Forms.GroupBox();
            this.groupBoxStatusHighCheckingResult = new System.Windows.Forms.GroupBox();
            this.listViewStatusHighCheckingResult = new System.Windows.Forms.ListView();
            this.buttonStatusHighChecking = new System.Windows.Forms.Button();
            this.buttonStatusChecking = new System.Windows.Forms.Button();
            this.groupBoxStatusCheckingResult = new System.Windows.Forms.GroupBox();
            this.listViewStatusCheckingResult = new System.Windows.Forms.ListView();
            this.groupBoxCapturing = new System.Windows.Forms.GroupBox();
            this.radioButtonCaptureProhibit = new System.Windows.Forms.RadioButton();
            this.radioButtonCaptureAllow = new System.Windows.Forms.RadioButton();
            this.radioButtonCaptureAllowReadWrite = new System.Windows.Forms.RadioButton();
            this.buttonCaptureSet = new System.Windows.Forms.Button();
            this.buttonCaptureGet = new System.Windows.Forms.Button();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.comboBoxPositions = new System.Windows.Forms.ComboBox();
            this.buttonSetPosition = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.groupBoxMifare = new System.Windows.Forms.GroupBox();
            this.buttonMifareCardSeek = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBeepOn = new System.Windows.Forms.Button();
            this.buttonRfReset = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonMifareReadCardSerial = new System.Windows.Forms.Button();
            this.buttonCheckSectorPassword = new System.Windows.Forms.Button();
            this.textBoxSectorPassword = new System.Windows.Forms.TextBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.groupBoxCom.SuspendLayout();
            this.groupBoxCard.SuspendLayout();
            this.groupBoxChecking.SuspendLayout();
            this.groupBoxStatusHighCheckingResult.SuspendLayout();
            this.groupBoxStatusCheckingResult.SuspendLayout();
            this.groupBoxCapturing.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.groupBoxMifare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCom
            // 
            this.groupBoxCom.Controls.Add(this.buttonComRefresh);
            this.groupBoxCom.Controls.Add(this.comboBoxPorts);
            this.groupBoxCom.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCom.Name = "groupBoxCom";
            this.groupBoxCom.Size = new System.Drawing.Size(392, 181);
            this.groupBoxCom.TabIndex = 0;
            this.groupBoxCom.TabStop = false;
            this.groupBoxCom.Text = "Port settings";
            // 
            // buttonComRefresh
            // 
            this.buttonComRefresh.Location = new System.Drawing.Point(10, 107);
            this.buttonComRefresh.Name = "buttonComRefresh";
            this.buttonComRefresh.Size = new System.Drawing.Size(150, 50);
            this.buttonComRefresh.TabIndex = 1;
            this.buttonComRefresh.Text = "Refresh";
            this.buttonComRefresh.UseVisualStyleBackColor = true;
            this.buttonComRefresh.Click += new System.EventHandler(this.buttonComRefresh_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(10, 53);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(350, 45);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.buttonCapture);
            this.groupBoxCard.Controls.Add(this.buttonDispense);
            this.groupBoxCard.Enabled = false;
            this.groupBoxCard.Location = new System.Drawing.Point(431, 12);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(467, 181);
            this.groupBoxCard.TabIndex = 1;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Card operations";
            // 
            // buttonDispense
            // 
            this.buttonDispense.Location = new System.Drawing.Point(22, 53);
            this.buttonDispense.Name = "buttonDispense";
            this.buttonDispense.Size = new System.Drawing.Size(188, 50);
            this.buttonDispense.TabIndex = 0;
            this.buttonDispense.Text = "Dispense";
            this.buttonDispense.UseVisualStyleBackColor = true;
            this.buttonDispense.Click += new System.EventHandler(this.buttonDispense_Click);
            // 
            // groupBoxChecking
            // 
            this.groupBoxChecking.Controls.Add(this.buttonReset);
            this.groupBoxChecking.Controls.Add(this.groupBoxStatusHighCheckingResult);
            this.groupBoxChecking.Controls.Add(this.buttonStatusHighChecking);
            this.groupBoxChecking.Controls.Add(this.buttonStatusChecking);
            this.groupBoxChecking.Controls.Add(this.groupBoxStatusCheckingResult);
            this.groupBoxChecking.Location = new System.Drawing.Point(12, 199);
            this.groupBoxChecking.Name = "groupBoxChecking";
            this.groupBoxChecking.Size = new System.Drawing.Size(886, 691);
            this.groupBoxChecking.TabIndex = 2;
            this.groupBoxChecking.TabStop = false;
            this.groupBoxChecking.Text = "Checking";
            // 
            // groupBoxStatusHighCheckingResult
            // 
            this.groupBoxStatusHighCheckingResult.Controls.Add(this.listViewStatusHighCheckingResult);
            this.groupBoxStatusHighCheckingResult.Location = new System.Drawing.Point(389, 121);
            this.groupBoxStatusHighCheckingResult.Name = "groupBoxStatusHighCheckingResult";
            this.groupBoxStatusHighCheckingResult.Size = new System.Drawing.Size(308, 488);
            this.groupBoxStatusHighCheckingResult.TabIndex = 4;
            this.groupBoxStatusHighCheckingResult.TabStop = false;
            this.groupBoxStatusHighCheckingResult.Text = "Checking results";
            // 
            // listViewStatusHighCheckingResult
            // 
            this.listViewStatusHighCheckingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatusHighCheckingResult.GridLines = true;
            this.listViewStatusHighCheckingResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStatusHighCheckingResult.HideSelection = false;
            this.listViewStatusHighCheckingResult.Location = new System.Drawing.Point(3, 27);
            this.listViewStatusHighCheckingResult.MultiSelect = false;
            this.listViewStatusHighCheckingResult.Name = "listViewStatusHighCheckingResult";
            this.listViewStatusHighCheckingResult.ShowGroups = false;
            this.listViewStatusHighCheckingResult.Size = new System.Drawing.Size(302, 458);
            this.listViewStatusHighCheckingResult.TabIndex = 0;
            this.listViewStatusHighCheckingResult.UseCompatibleStateImageBehavior = false;
            this.listViewStatusHighCheckingResult.View = System.Windows.Forms.View.List;
            // 
            // buttonStatusHighChecking
            // 
            this.buttonStatusHighChecking.Location = new System.Drawing.Point(389, 52);
            this.buttonStatusHighChecking.Name = "buttonStatusHighChecking";
            this.buttonStatusHighChecking.Size = new System.Drawing.Size(308, 50);
            this.buttonStatusHighChecking.TabIndex = 4;
            this.buttonStatusHighChecking.Text = "Status high checking";
            this.buttonStatusHighChecking.UseVisualStyleBackColor = true;
            this.buttonStatusHighChecking.Click += new System.EventHandler(this.buttonStatusHighChecking_Click);
            // 
            // buttonStatusChecking
            // 
            this.buttonStatusChecking.Location = new System.Drawing.Point(23, 53);
            this.buttonStatusChecking.Name = "buttonStatusChecking";
            this.buttonStatusChecking.Size = new System.Drawing.Size(308, 50);
            this.buttonStatusChecking.TabIndex = 0;
            this.buttonStatusChecking.Text = "Status checking";
            this.buttonStatusChecking.UseVisualStyleBackColor = true;
            this.buttonStatusChecking.Click += new System.EventHandler(this.buttonStatusChecking_Click);
            // 
            // groupBoxStatusCheckingResult
            // 
            this.groupBoxStatusCheckingResult.Controls.Add(this.listViewStatusCheckingResult);
            this.groupBoxStatusCheckingResult.Location = new System.Drawing.Point(23, 121);
            this.groupBoxStatusCheckingResult.Name = "groupBoxStatusCheckingResult";
            this.groupBoxStatusCheckingResult.Size = new System.Drawing.Size(308, 488);
            this.groupBoxStatusCheckingResult.TabIndex = 3;
            this.groupBoxStatusCheckingResult.TabStop = false;
            this.groupBoxStatusCheckingResult.Text = "Checking results";
            // 
            // listViewStatusCheckingResult
            // 
            this.listViewStatusCheckingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatusCheckingResult.GridLines = true;
            this.listViewStatusCheckingResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStatusCheckingResult.HideSelection = false;
            this.listViewStatusCheckingResult.Location = new System.Drawing.Point(3, 27);
            this.listViewStatusCheckingResult.MultiSelect = false;
            this.listViewStatusCheckingResult.Name = "listViewStatusCheckingResult";
            this.listViewStatusCheckingResult.ShowGroups = false;
            this.listViewStatusCheckingResult.Size = new System.Drawing.Size(302, 458);
            this.listViewStatusCheckingResult.TabIndex = 0;
            this.listViewStatusCheckingResult.UseCompatibleStateImageBehavior = false;
            this.listViewStatusCheckingResult.View = System.Windows.Forms.View.List;
            // 
            // groupBoxCapturing
            // 
            this.groupBoxCapturing.Controls.Add(this.buttonCaptureGet);
            this.groupBoxCapturing.Controls.Add(this.buttonCaptureSet);
            this.groupBoxCapturing.Controls.Add(this.radioButtonCaptureAllowReadWrite);
            this.groupBoxCapturing.Controls.Add(this.radioButtonCaptureAllow);
            this.groupBoxCapturing.Controls.Add(this.radioButtonCaptureProhibit);
            this.groupBoxCapturing.Location = new System.Drawing.Point(915, 12);
            this.groupBoxCapturing.Name = "groupBoxCapturing";
            this.groupBoxCapturing.Size = new System.Drawing.Size(398, 181);
            this.groupBoxCapturing.TabIndex = 1;
            this.groupBoxCapturing.TabStop = false;
            this.groupBoxCapturing.Text = "Capturing";
            // 
            // radioButtonCaptureProhibit
            // 
            this.radioButtonCaptureProhibit.AutoSize = true;
            this.radioButtonCaptureProhibit.Location = new System.Drawing.Point(16, 42);
            this.radioButtonCaptureProhibit.Name = "radioButtonCaptureProhibit";
            this.radioButtonCaptureProhibit.Size = new System.Drawing.Size(116, 29);
            this.radioButtonCaptureProhibit.TabIndex = 0;
            this.radioButtonCaptureProhibit.Text = "Prohibit";
            this.radioButtonCaptureProhibit.UseVisualStyleBackColor = true;
            this.radioButtonCaptureProhibit.CheckedChanged += new System.EventHandler(this.radioButtonCaptureProhibit_CheckedChanged);
            // 
            // radioButtonCaptureAllow
            // 
            this.radioButtonCaptureAllow.AutoSize = true;
            this.radioButtonCaptureAllow.Location = new System.Drawing.Point(16, 88);
            this.radioButtonCaptureAllow.Name = "radioButtonCaptureAllow";
            this.radioButtonCaptureAllow.Size = new System.Drawing.Size(94, 29);
            this.radioButtonCaptureAllow.TabIndex = 1;
            this.radioButtonCaptureAllow.Text = "Allow";
            this.radioButtonCaptureAllow.UseVisualStyleBackColor = true;
            this.radioButtonCaptureAllow.CheckedChanged += new System.EventHandler(this.radioButtonCaptureAllow_CheckedChanged);
            // 
            // radioButtonCaptureAllowReadWrite
            // 
            this.radioButtonCaptureAllowReadWrite.AutoSize = true;
            this.radioButtonCaptureAllowReadWrite.Location = new System.Drawing.Point(16, 133);
            this.radioButtonCaptureAllowReadWrite.Name = "radioButtonCaptureAllowReadWrite";
            this.radioButtonCaptureAllowReadWrite.Size = new System.Drawing.Size(194, 29);
            this.radioButtonCaptureAllowReadWrite.TabIndex = 2;
            this.radioButtonCaptureAllowReadWrite.Text = "Allow read\\write";
            this.radioButtonCaptureAllowReadWrite.UseVisualStyleBackColor = true;
            this.radioButtonCaptureAllowReadWrite.CheckedChanged += new System.EventHandler(this.radioButtonCaptureAllowReadWrite_CheckedChanged);
            // 
            // buttonCaptureSet
            // 
            this.buttonCaptureSet.Location = new System.Drawing.Point(234, 112);
            this.buttonCaptureSet.Name = "buttonCaptureSet";
            this.buttonCaptureSet.Size = new System.Drawing.Size(158, 50);
            this.buttonCaptureSet.TabIndex = 3;
            this.buttonCaptureSet.Text = "Set";
            this.buttonCaptureSet.UseVisualStyleBackColor = true;
            this.buttonCaptureSet.Click += new System.EventHandler(this.buttonCaptureApply_Click);
            // 
            // buttonCaptureGet
            // 
            this.buttonCaptureGet.Location = new System.Drawing.Point(234, 30);
            this.buttonCaptureGet.Name = "buttonCaptureGet";
            this.buttonCaptureGet.Size = new System.Drawing.Size(158, 50);
            this.buttonCaptureGet.TabIndex = 4;
            this.buttonCaptureGet.Text = "Get";
            this.buttonCaptureGet.UseVisualStyleBackColor = true;
            this.buttonCaptureGet.Click += new System.EventHandler(this.buttonCaptureGet_Click);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.buttonSetPosition);
            this.groupBoxPosition.Controls.Add(this.comboBoxPositions);
            this.groupBoxPosition.Location = new System.Drawing.Point(915, 199);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(398, 189);
            this.groupBoxPosition.TabIndex = 3;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Positioning";
            // 
            // comboBoxPositions
            // 
            this.comboBoxPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPositions.FormattingEnabled = true;
            this.comboBoxPositions.Location = new System.Drawing.Point(16, 52);
            this.comboBoxPositions.Name = "comboBoxPositions";
            this.comboBoxPositions.Size = new System.Drawing.Size(376, 33);
            this.comboBoxPositions.TabIndex = 0;
            // 
            // buttonSetPosition
            // 
            this.buttonSetPosition.Location = new System.Drawing.Point(16, 109);
            this.buttonSetPosition.Name = "buttonSetPosition";
            this.buttonSetPosition.Size = new System.Drawing.Size(376, 50);
            this.buttonSetPosition.TabIndex = 5;
            this.buttonSetPosition.Text = "Set";
            this.buttonSetPosition.UseVisualStyleBackColor = true;
            this.buttonSetPosition.Click += new System.EventHandler(this.buttonSetPosition_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(241, 53);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(197, 50);
            this.buttonCapture.TabIndex = 1;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // groupBoxMifare
            // 
            this.groupBoxMifare.Controls.Add(this.comboBoxSector);
            this.groupBoxMifare.Controls.Add(this.textBoxSectorPassword);
            this.groupBoxMifare.Controls.Add(this.buttonCheckSectorPassword);
            this.groupBoxMifare.Controls.Add(this.buttonMifareReadCardSerial);
            this.groupBoxMifare.Controls.Add(this.buttonOff);
            this.groupBoxMifare.Controls.Add(this.buttonRfReset);
            this.groupBoxMifare.Controls.Add(this.buttonBeepOn);
            this.groupBoxMifare.Controls.Add(this.buttonMifareCardSeek);
            this.groupBoxMifare.Location = new System.Drawing.Point(915, 411);
            this.groupBoxMifare.Name = "groupBoxMifare";
            this.groupBoxMifare.Size = new System.Drawing.Size(885, 479);
            this.groupBoxMifare.TabIndex = 4;
            this.groupBoxMifare.TabStop = false;
            this.groupBoxMifare.Text = "Mifare";
            // 
            // buttonMifareCardSeek
            // 
            this.buttonMifareCardSeek.Location = new System.Drawing.Point(16, 46);
            this.buttonMifareCardSeek.Name = "buttonMifareCardSeek";
            this.buttonMifareCardSeek.Size = new System.Drawing.Size(376, 50);
            this.buttonMifareCardSeek.TabIndex = 6;
            this.buttonMifareCardSeek.Text = "Seek";
            this.buttonMifareCardSeek.UseVisualStyleBackColor = true;
            this.buttonMifareCardSeek.Click += new System.EventHandler(this.buttonMifareSeek_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(23, 630);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(305, 40);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBeepOn
            // 
            this.buttonBeepOn.Location = new System.Drawing.Point(11, 297);
            this.buttonBeepOn.Name = "buttonBeepOn";
            this.buttonBeepOn.Size = new System.Drawing.Size(376, 50);
            this.buttonBeepOn.TabIndex = 7;
            this.buttonBeepOn.Text = "Beep On";
            this.buttonBeepOn.UseVisualStyleBackColor = true;
            this.buttonBeepOn.Click += new System.EventHandler(this.buttonBeep_Click);
            // 
            // buttonRfReset
            // 
            this.buttonRfReset.Location = new System.Drawing.Point(16, 433);
            this.buttonRfReset.Name = "buttonRfReset";
            this.buttonRfReset.Size = new System.Drawing.Size(376, 40);
            this.buttonRfReset.TabIndex = 8;
            this.buttonRfReset.Text = "Reader Reset";
            this.buttonRfReset.UseVisualStyleBackColor = true;
            this.buttonRfReset.Click += new System.EventHandler(this.buttonRfReset_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(11, 360);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(376, 50);
            this.buttonOff.TabIndex = 9;
            this.buttonOff.Text = "Beep Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(12, 940);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(1301, 89);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonMifareReadCardSerial
            // 
            this.buttonMifareReadCardSerial.Location = new System.Drawing.Point(16, 102);
            this.buttonMifareReadCardSerial.Name = "buttonMifareReadCardSerial";
            this.buttonMifareReadCardSerial.Size = new System.Drawing.Size(376, 50);
            this.buttonMifareReadCardSerial.TabIndex = 10;
            this.buttonMifareReadCardSerial.Text = "Read Serial";
            this.buttonMifareReadCardSerial.UseVisualStyleBackColor = true;
            this.buttonMifareReadCardSerial.Click += new System.EventHandler(this.buttonMifareReadCardSerial_Click);
            // 
            // buttonCheckSectorPassword
            // 
            this.buttonCheckSectorPassword.Location = new System.Drawing.Point(467, 159);
            this.buttonCheckSectorPassword.Name = "buttonCheckSectorPassword";
            this.buttonCheckSectorPassword.Size = new System.Drawing.Size(376, 50);
            this.buttonCheckSectorPassword.TabIndex = 11;
            this.buttonCheckSectorPassword.Text = "Check Password";
            this.buttonCheckSectorPassword.UseVisualStyleBackColor = true;
            this.buttonCheckSectorPassword.Click += new System.EventHandler(this.buttonCheckSectorPassword_Click);
            // 
            // textBoxSectorPassword
            // 
            this.textBoxSectorPassword.Location = new System.Drawing.Point(467, 102);
            this.textBoxSectorPassword.MaxLength = 12;
            this.textBoxSectorPassword.Name = "textBoxSectorPassword";
            this.textBoxSectorPassword.Size = new System.Drawing.Size(376, 31);
            this.textBoxSectorPassword.TabIndex = 13;
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(467, 46);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSector.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 1056);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBoxMifare);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.groupBoxChecking);
            this.Controls.Add(this.groupBoxCapturing);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.groupBoxCom);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBoxCom.ResumeLayout(false);
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxChecking.ResumeLayout(false);
            this.groupBoxStatusHighCheckingResult.ResumeLayout(false);
            this.groupBoxStatusCheckingResult.ResumeLayout(false);
            this.groupBoxCapturing.ResumeLayout(false);
            this.groupBoxCapturing.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxMifare.ResumeLayout(false);
            this.groupBoxMifare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCom;
        private System.Windows.Forms.Button buttonComRefresh;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.Button buttonDispense;
        private System.Windows.Forms.GroupBox groupBoxChecking;
        private System.Windows.Forms.Button buttonStatusChecking;
        private System.Windows.Forms.GroupBox groupBoxStatusCheckingResult;
        private System.Windows.Forms.ListView listViewStatusCheckingResult;
        private System.Windows.Forms.GroupBox groupBoxStatusHighCheckingResult;
        private System.Windows.Forms.ListView listViewStatusHighCheckingResult;
        private System.Windows.Forms.Button buttonStatusHighChecking;
        private System.Windows.Forms.GroupBox groupBoxCapturing;
        private System.Windows.Forms.Button buttonCaptureSet;
        private System.Windows.Forms.RadioButton radioButtonCaptureAllowReadWrite;
        private System.Windows.Forms.RadioButton radioButtonCaptureAllow;
        private System.Windows.Forms.RadioButton radioButtonCaptureProhibit;
        private System.Windows.Forms.Button buttonCaptureGet;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.Button buttonSetPosition;
        private System.Windows.Forms.ComboBox comboBoxPositions;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.GroupBox groupBoxMifare;
        private System.Windows.Forms.Button buttonMifareCardSeek;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBeepOn;
        private System.Windows.Forms.Button buttonRfReset;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonMifareReadCardSerial;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.TextBox textBoxSectorPassword;
        private System.Windows.Forms.Button buttonCheckSectorPassword;
    }
}

