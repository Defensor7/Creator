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
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonDispense = new System.Windows.Forms.Button();
            this.groupBoxChecking = new System.Windows.Forms.GroupBox();
            this.buttonResetDispenser = new System.Windows.Forms.Button();
            this.groupBoxStatusHighCheckingResult = new System.Windows.Forms.GroupBox();
            this.listViewStatusHighCheckingResult = new System.Windows.Forms.ListView();
            this.buttonStatusHighChecking = new System.Windows.Forms.Button();
            this.buttonStatusChecking = new System.Windows.Forms.Button();
            this.groupBoxStatusCheckingResult = new System.Windows.Forms.GroupBox();
            this.listViewStatusCheckingResult = new System.Windows.Forms.ListView();
            this.groupBoxCapturing = new System.Windows.Forms.GroupBox();
            this.buttonCaptureGet = new System.Windows.Forms.Button();
            this.buttonCaptureSet = new System.Windows.Forms.Button();
            this.radioButtonCaptureAllowReadWrite = new System.Windows.Forms.RadioButton();
            this.radioButtonCaptureAllow = new System.Windows.Forms.RadioButton();
            this.radioButtonCaptureProhibit = new System.Windows.Forms.RadioButton();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.buttonSetPosition = new System.Windows.Forms.Button();
            this.comboBoxPositions = new System.Windows.Forms.ComboBox();
            this.groupBoxMifare = new System.Windows.Forms.GroupBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.textBoxSectorPassword = new System.Windows.Forms.TextBox();
            this.buttonCheckSectorPasswordA = new System.Windows.Forms.Button();
            this.buttonMifareReadCardSerial = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonRfReset = new System.Windows.Forms.Button();
            this.buttonBeepOn = new System.Windows.Forms.Button();
            this.buttonMifareCardSeek = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCheckSectorPasswordB = new System.Windows.Forms.Button();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
            this.buttonReadBlock = new System.Windows.Forms.Button();
            this.labelSector = new System.Windows.Forms.Label();
            this.labelBlock = new System.Windows.Forms.Label();
            this.textBoxBlockData = new System.Windows.Forms.TextBox();
            this.buttonWriteBlock = new System.Windows.Forms.Button();
            this.textBoxPasswordA = new System.Windows.Forms.TextBox();
            this.groupBoxPasswords = new System.Windows.Forms.GroupBox();
            this.labelPasswordA = new System.Windows.Forms.Label();
            this.textBoxPasswordB = new System.Windows.Forms.TextBox();
            this.labelPasswordB = new System.Windows.Forms.Label();
            this.buttonChangePasswords = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWriteData = new System.Windows.Forms.Label();
            this.groupBoxReading = new System.Windows.Forms.GroupBox();
            this.groupBoxCheckAccess = new System.Windows.Forms.GroupBox();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.labelSeekWarning = new System.Windows.Forms.Label();
            this.groupBoxCom.SuspendLayout();
            this.groupBoxCard.SuspendLayout();
            this.groupBoxChecking.SuspendLayout();
            this.groupBoxStatusHighCheckingResult.SuspendLayout();
            this.groupBoxStatusCheckingResult.SuspendLayout();
            this.groupBoxCapturing.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.groupBoxMifare.SuspendLayout();
            this.groupBoxPasswords.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxReading.SuspendLayout();
            this.groupBoxCheckAccess.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCom
            // 
            this.groupBoxCom.Controls.Add(this.buttonComRefresh);
            this.groupBoxCom.Controls.Add(this.comboBoxPorts);
            this.groupBoxCom.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCom.Name = "groupBoxCom";
            this.groupBoxCom.Size = new System.Drawing.Size(354, 181);
            this.groupBoxCom.TabIndex = 0;
            this.groupBoxCom.TabStop = false;
            this.groupBoxCom.Text = "Port settings";
            // 
            // buttonComRefresh
            // 
            this.buttonComRefresh.Location = new System.Drawing.Point(23, 107);
            this.buttonComRefresh.Name = "buttonComRefresh";
            this.buttonComRefresh.Size = new System.Drawing.Size(308, 50);
            this.buttonComRefresh.TabIndex = 1;
            this.buttonComRefresh.Text = "Refresh";
            this.buttonComRefresh.UseVisualStyleBackColor = true;
            this.buttonComRefresh.Click += new System.EventHandler(this.buttonComRefresh_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(26, 48);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(308, 33);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.buttonCapture);
            this.groupBoxCard.Controls.Add(this.buttonDispense);
            this.groupBoxCard.Enabled = false;
            this.groupBoxCard.Location = new System.Drawing.Point(372, 12);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(364, 181);
            this.groupBoxCard.TabIndex = 1;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Card operations";
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(29, 107);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(308, 50);
            this.buttonCapture.TabIndex = 1;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonDispense
            // 
            this.buttonDispense.Location = new System.Drawing.Point(29, 48);
            this.buttonDispense.Name = "buttonDispense";
            this.buttonDispense.Size = new System.Drawing.Size(308, 50);
            this.buttonDispense.TabIndex = 0;
            this.buttonDispense.Text = "Dispense";
            this.buttonDispense.UseVisualStyleBackColor = true;
            this.buttonDispense.Click += new System.EventHandler(this.buttonDispense_Click);
            // 
            // groupBoxChecking
            // 
            this.groupBoxChecking.Controls.Add(this.buttonResetDispenser);
            this.groupBoxChecking.Controls.Add(this.groupBoxStatusHighCheckingResult);
            this.groupBoxChecking.Controls.Add(this.buttonStatusHighChecking);
            this.groupBoxChecking.Controls.Add(this.buttonStatusChecking);
            this.groupBoxChecking.Controls.Add(this.groupBoxStatusCheckingResult);
            this.groupBoxChecking.Location = new System.Drawing.Point(12, 199);
            this.groupBoxChecking.Name = "groupBoxChecking";
            this.groupBoxChecking.Size = new System.Drawing.Size(724, 735);
            this.groupBoxChecking.TabIndex = 2;
            this.groupBoxChecking.TabStop = false;
            this.groupBoxChecking.Text = "Checking";
            // 
            // buttonResetDispenser
            // 
            this.buttonResetDispenser.Location = new System.Drawing.Point(23, 677);
            this.buttonResetDispenser.Name = "buttonResetDispenser";
            this.buttonResetDispenser.Size = new System.Drawing.Size(674, 40);
            this.buttonResetDispenser.TabIndex = 7;
            this.buttonResetDispenser.Text = "Reset Dispenser";
            this.buttonResetDispenser.UseVisualStyleBackColor = true;
            this.buttonResetDispenser.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxStatusHighCheckingResult
            // 
            this.groupBoxStatusHighCheckingResult.Controls.Add(this.listViewStatusHighCheckingResult);
            this.groupBoxStatusHighCheckingResult.Location = new System.Drawing.Point(389, 121);
            this.groupBoxStatusHighCheckingResult.Name = "groupBoxStatusHighCheckingResult";
            this.groupBoxStatusHighCheckingResult.Size = new System.Drawing.Size(308, 531);
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
            this.listViewStatusHighCheckingResult.Size = new System.Drawing.Size(302, 501);
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
            this.groupBoxStatusCheckingResult.Size = new System.Drawing.Size(308, 534);
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
            this.listViewStatusCheckingResult.Size = new System.Drawing.Size(302, 504);
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
            this.groupBoxCapturing.Location = new System.Drawing.Point(742, 12);
            this.groupBoxCapturing.Name = "groupBoxCapturing";
            this.groupBoxCapturing.Size = new System.Drawing.Size(398, 181);
            this.groupBoxCapturing.TabIndex = 1;
            this.groupBoxCapturing.TabStop = false;
            this.groupBoxCapturing.Text = "Capturing";
            // 
            // buttonCaptureGet
            // 
            this.buttonCaptureGet.Location = new System.Drawing.Point(234, 52);
            this.buttonCaptureGet.Name = "buttonCaptureGet";
            this.buttonCaptureGet.Size = new System.Drawing.Size(158, 50);
            this.buttonCaptureGet.TabIndex = 4;
            this.buttonCaptureGet.Text = "Get";
            this.buttonCaptureGet.UseVisualStyleBackColor = true;
            this.buttonCaptureGet.Click += new System.EventHandler(this.buttonCaptureGet_Click);
            // 
            // buttonCaptureSet
            // 
            this.buttonCaptureSet.Location = new System.Drawing.Point(234, 107);
            this.buttonCaptureSet.Name = "buttonCaptureSet";
            this.buttonCaptureSet.Size = new System.Drawing.Size(158, 50);
            this.buttonCaptureSet.TabIndex = 3;
            this.buttonCaptureSet.Text = "Set";
            this.buttonCaptureSet.UseVisualStyleBackColor = true;
            this.buttonCaptureSet.Click += new System.EventHandler(this.buttonCaptureApply_Click);
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
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.buttonSetPosition);
            this.groupBoxPosition.Controls.Add(this.comboBoxPositions);
            this.groupBoxPosition.Location = new System.Drawing.Point(1146, 12);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(406, 181);
            this.groupBoxPosition.TabIndex = 3;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Positioning";
            // 
            // buttonSetPosition
            // 
            this.buttonSetPosition.Location = new System.Drawing.Point(16, 107);
            this.buttonSetPosition.Name = "buttonSetPosition";
            this.buttonSetPosition.Size = new System.Drawing.Size(376, 50);
            this.buttonSetPosition.TabIndex = 5;
            this.buttonSetPosition.Text = "Set";
            this.buttonSetPosition.UseVisualStyleBackColor = true;
            this.buttonSetPosition.Click += new System.EventHandler(this.buttonSetPosition_Click);
            // 
            // comboBoxPositions
            // 
            this.comboBoxPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPositions.FormattingEnabled = true;
            this.comboBoxPositions.Location = new System.Drawing.Point(16, 53);
            this.comboBoxPositions.Name = "comboBoxPositions";
            this.comboBoxPositions.Size = new System.Drawing.Size(376, 33);
            this.comboBoxPositions.TabIndex = 0;
            // 
            // groupBoxMifare
            // 
            this.groupBoxMifare.Controls.Add(this.labelSeekWarning);
            this.groupBoxMifare.Controls.Add(this.groupBoxAddress);
            this.groupBoxMifare.Controls.Add(this.groupBoxCheckAccess);
            this.groupBoxMifare.Controls.Add(this.groupBoxReading);
            this.groupBoxMifare.Controls.Add(this.groupBox1);
            this.groupBoxMifare.Controls.Add(this.groupBoxPasswords);
            this.groupBoxMifare.Controls.Add(this.buttonMifareReadCardSerial);
            this.groupBoxMifare.Controls.Add(this.buttonOff);
            this.groupBoxMifare.Controls.Add(this.buttonRfReset);
            this.groupBoxMifare.Controls.Add(this.buttonBeepOn);
            this.groupBoxMifare.Controls.Add(this.buttonMifareCardSeek);
            this.groupBoxMifare.Location = new System.Drawing.Point(742, 199);
            this.groupBoxMifare.Name = "groupBoxMifare";
            this.groupBoxMifare.Size = new System.Drawing.Size(810, 735);
            this.groupBoxMifare.TabIndex = 4;
            this.groupBoxMifare.TabStop = false;
            this.groupBoxMifare.Text = "Mifare";
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(104, 33);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSector.TabIndex = 14;
            // 
            // textBoxSectorPassword
            // 
            this.textBoxSectorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectorPassword.Location = new System.Drawing.Point(14, 44);
            this.textBoxSectorPassword.MaxLength = 12;
            this.textBoxSectorPassword.Name = "textBoxSectorPassword";
            this.textBoxSectorPassword.Size = new System.Drawing.Size(350, 44);
            this.textBoxSectorPassword.TabIndex = 13;
            this.textBoxSectorPassword.Text = "FFFFFFFFFFFF";
            // 
            // buttonCheckSectorPasswordA
            // 
            this.buttonCheckSectorPasswordA.Location = new System.Drawing.Point(14, 102);
            this.buttonCheckSectorPasswordA.Name = "buttonCheckSectorPasswordA";
            this.buttonCheckSectorPasswordA.Size = new System.Drawing.Size(172, 50);
            this.buttonCheckSectorPasswordA.TabIndex = 11;
            this.buttonCheckSectorPasswordA.Text = "Check Pass A";
            this.buttonCheckSectorPasswordA.UseVisualStyleBackColor = true;
            this.buttonCheckSectorPasswordA.Click += new System.EventHandler(this.buttonCheckSectorPassword_Click);
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
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(16, 214);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(376, 50);
            this.buttonOff.TabIndex = 9;
            this.buttonOff.Text = "Beep Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonRfReset
            // 
            this.buttonRfReset.Location = new System.Drawing.Point(16, 270);
            this.buttonRfReset.Name = "buttonRfReset";
            this.buttonRfReset.Size = new System.Drawing.Size(376, 50);
            this.buttonRfReset.TabIndex = 8;
            this.buttonRfReset.Text = "Reset Reader";
            this.buttonRfReset.UseVisualStyleBackColor = true;
            this.buttonRfReset.Click += new System.EventHandler(this.buttonRfReset_Click);
            // 
            // buttonBeepOn
            // 
            this.buttonBeepOn.Location = new System.Drawing.Point(16, 158);
            this.buttonBeepOn.Name = "buttonBeepOn";
            this.buttonBeepOn.Size = new System.Drawing.Size(376, 50);
            this.buttonBeepOn.TabIndex = 7;
            this.buttonBeepOn.Text = "Beep On";
            this.buttonBeepOn.UseVisualStyleBackColor = true;
            this.buttonBeepOn.Click += new System.EventHandler(this.buttonBeep_Click);
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
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 940);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(1540, 89);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonCheckSectorPasswordB
            // 
            this.buttonCheckSectorPasswordB.Location = new System.Drawing.Point(202, 102);
            this.buttonCheckSectorPasswordB.Name = "buttonCheckSectorPasswordB";
            this.buttonCheckSectorPasswordB.Size = new System.Drawing.Size(162, 50);
            this.buttonCheckSectorPasswordB.TabIndex = 15;
            this.buttonCheckSectorPasswordB.Text = "Check Pass B";
            this.buttonCheckSectorPasswordB.UseVisualStyleBackColor = true;
            this.buttonCheckSectorPasswordB.Click += new System.EventHandler(this.buttonCheckSectorPasswordB_Click);
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Location = new System.Drawing.Point(104, 89);
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(121, 33);
            this.comboBoxBlock.TabIndex = 16;
            // 
            // buttonReadBlock
            // 
            this.buttonReadBlock.Location = new System.Drawing.Point(6, 114);
            this.buttonReadBlock.Name = "buttonReadBlock";
            this.buttonReadBlock.Size = new System.Drawing.Size(364, 50);
            this.buttonReadBlock.TabIndex = 17;
            this.buttonReadBlock.Text = "Read Block";
            this.buttonReadBlock.UseVisualStyleBackColor = true;
            this.buttonReadBlock.Click += new System.EventHandler(this.buttonReadBlock_Click);
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Location = new System.Drawing.Point(9, 41);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(74, 25);
            this.labelSector.TabIndex = 18;
            this.labelSector.Text = "Sector";
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(9, 97);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(65, 25);
            this.labelBlock.TabIndex = 19;
            this.labelBlock.Text = "Block";
            // 
            // textBoxBlockData
            // 
            this.textBoxBlockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlockData.Location = new System.Drawing.Point(6, 71);
            this.textBoxBlockData.MaxLength = 32;
            this.textBoxBlockData.Name = "textBoxBlockData";
            this.textBoxBlockData.Size = new System.Drawing.Size(364, 31);
            this.textBoxBlockData.TabIndex = 20;
            // 
            // buttonWriteBlock
            // 
            this.buttonWriteBlock.Location = new System.Drawing.Point(6, 114);
            this.buttonWriteBlock.Name = "buttonWriteBlock";
            this.buttonWriteBlock.Size = new System.Drawing.Size(364, 50);
            this.buttonWriteBlock.TabIndex = 21;
            this.buttonWriteBlock.Text = "Write Block";
            this.buttonWriteBlock.UseVisualStyleBackColor = true;
            this.buttonWriteBlock.Click += new System.EventHandler(this.buttonWriteBlock_Click);
            // 
            // textBoxPasswordA
            // 
            this.textBoxPasswordA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordA.Location = new System.Drawing.Point(6, 70);
            this.textBoxPasswordA.MaxLength = 12;
            this.textBoxPasswordA.Name = "textBoxPasswordA";
            this.textBoxPasswordA.Size = new System.Drawing.Size(174, 31);
            this.textBoxPasswordA.TabIndex = 22;
            // 
            // groupBoxPasswords
            // 
            this.groupBoxPasswords.Controls.Add(this.buttonChangePasswords);
            this.groupBoxPasswords.Controls.Add(this.labelPasswordB);
            this.groupBoxPasswords.Controls.Add(this.textBoxPasswordB);
            this.groupBoxPasswords.Controls.Add(this.labelPasswordA);
            this.groupBoxPasswords.Controls.Add(this.textBoxPasswordA);
            this.groupBoxPasswords.Location = new System.Drawing.Point(16, 544);
            this.groupBoxPasswords.Name = "groupBoxPasswords";
            this.groupBoxPasswords.Size = new System.Drawing.Size(375, 180);
            this.groupBoxPasswords.TabIndex = 23;
            this.groupBoxPasswords.TabStop = false;
            this.groupBoxPasswords.Text = "Passwords";
            // 
            // labelPasswordA
            // 
            this.labelPasswordA.AutoSize = true;
            this.labelPasswordA.Location = new System.Drawing.Point(1, 40);
            this.labelPasswordA.Name = "labelPasswordA";
            this.labelPasswordA.Size = new System.Drawing.Size(126, 25);
            this.labelPasswordA.TabIndex = 23;
            this.labelPasswordA.Text = "Password A";
            // 
            // textBoxPasswordB
            // 
            this.textBoxPasswordB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordB.Location = new System.Drawing.Point(196, 70);
            this.textBoxPasswordB.MaxLength = 12;
            this.textBoxPasswordB.Name = "textBoxPasswordB";
            this.textBoxPasswordB.Size = new System.Drawing.Size(174, 31);
            this.textBoxPasswordB.TabIndex = 24;
            // 
            // labelPasswordB
            // 
            this.labelPasswordB.AutoSize = true;
            this.labelPasswordB.Location = new System.Drawing.Point(191, 40);
            this.labelPasswordB.Name = "labelPasswordB";
            this.labelPasswordB.Size = new System.Drawing.Size(126, 25);
            this.labelPasswordB.TabIndex = 25;
            this.labelPasswordB.Text = "Password B";
            // 
            // buttonChangePasswords
            // 
            this.buttonChangePasswords.Location = new System.Drawing.Point(6, 115);
            this.buttonChangePasswords.Name = "buttonChangePasswords";
            this.buttonChangePasswords.Size = new System.Drawing.Size(364, 50);
            this.buttonChangePasswords.TabIndex = 24;
            this.buttonChangePasswords.Text = "Change passwords";
            this.buttonChangePasswords.UseVisualStyleBackColor = true;
            this.buttonChangePasswords.Click += new System.EventHandler(this.buttonChangePasswords_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWriteData);
            this.groupBox1.Controls.Add(this.textBoxBlockData);
            this.groupBox1.Controls.Add(this.buttonWriteBlock);
            this.groupBox1.Location = new System.Drawing.Point(421, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 180);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Writing";
            // 
            // labelWriteData
            // 
            this.labelWriteData.AutoSize = true;
            this.labelWriteData.Location = new System.Drawing.Point(6, 43);
            this.labelWriteData.Name = "labelWriteData";
            this.labelWriteData.Size = new System.Drawing.Size(150, 25);
            this.labelWriteData.TabIndex = 26;
            this.labelWriteData.Text = "Data (32 HEX)";
            // 
            // groupBoxReading
            // 
            this.groupBoxReading.Controls.Add(this.buttonReadBlock);
            this.groupBoxReading.Location = new System.Drawing.Point(16, 363);
            this.groupBoxReading.Name = "groupBoxReading";
            this.groupBoxReading.Size = new System.Drawing.Size(376, 175);
            this.groupBoxReading.TabIndex = 25;
            this.groupBoxReading.TabStop = false;
            this.groupBoxReading.Text = "Reading";
            // 
            // groupBoxCheckAccess
            // 
            this.groupBoxCheckAccess.Controls.Add(this.textBoxSectorPassword);
            this.groupBoxCheckAccess.Controls.Add(this.buttonCheckSectorPasswordA);
            this.groupBoxCheckAccess.Controls.Add(this.buttonCheckSectorPasswordB);
            this.groupBoxCheckAccess.Location = new System.Drawing.Point(420, 190);
            this.groupBoxCheckAccess.Name = "groupBoxCheckAccess";
            this.groupBoxCheckAccess.Size = new System.Drawing.Size(370, 167);
            this.groupBoxCheckAccess.TabIndex = 26;
            this.groupBoxCheckAccess.TabStop = false;
            this.groupBoxCheckAccess.Text = "Access";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.labelSector);
            this.groupBoxAddress.Controls.Add(this.comboBoxSector);
            this.groupBoxAddress.Controls.Add(this.labelBlock);
            this.groupBoxAddress.Controls.Add(this.comboBoxBlock);
            this.groupBoxAddress.Location = new System.Drawing.Point(420, 30);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(370, 154);
            this.groupBoxAddress.TabIndex = 27;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // labelSeekWarning
            // 
            this.labelSeekWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeekWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSeekWarning.Location = new System.Drawing.Point(491, 596);
            this.labelSeekWarning.Name = "labelSeekWarning";
            this.labelSeekWarning.Size = new System.Drawing.Size(260, 97);
            this.labelSeekWarning.TabIndex = 28;
            this.labelSeekWarning.Text = "Always click Seek button first!";
            this.labelSeekWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 1054);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBoxMifare);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.groupBoxChecking);
            this.Controls.Add(this.groupBoxCapturing);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.groupBoxCom);
            this.Name = "Main";
            this.Text = "Creator CRT-570 + Creator CRT-601 Tool";
            this.groupBoxCom.ResumeLayout(false);
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxChecking.ResumeLayout(false);
            this.groupBoxStatusHighCheckingResult.ResumeLayout(false);
            this.groupBoxStatusCheckingResult.ResumeLayout(false);
            this.groupBoxCapturing.ResumeLayout(false);
            this.groupBoxCapturing.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxMifare.ResumeLayout(false);
            this.groupBoxPasswords.ResumeLayout(false);
            this.groupBoxPasswords.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxReading.ResumeLayout(false);
            this.groupBoxCheckAccess.ResumeLayout(false);
            this.groupBoxCheckAccess.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
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
        private System.Windows.Forms.Button buttonResetDispenser;
        private System.Windows.Forms.Button buttonBeepOn;
        private System.Windows.Forms.Button buttonRfReset;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonMifareReadCardSerial;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.TextBox textBoxSectorPassword;
        private System.Windows.Forms.Button buttonCheckSectorPasswordA;
        private System.Windows.Forms.Button buttonCheckSectorPasswordB;
        private System.Windows.Forms.Button buttonReadBlock;
        private System.Windows.Forms.ComboBox comboBoxBlock;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Button buttonWriteBlock;
        private System.Windows.Forms.TextBox textBoxBlockData;
        private System.Windows.Forms.GroupBox groupBoxPasswords;
        private System.Windows.Forms.Label labelPasswordA;
        private System.Windows.Forms.TextBox textBoxPasswordA;
        private System.Windows.Forms.Button buttonChangePasswords;
        private System.Windows.Forms.Label labelPasswordB;
        private System.Windows.Forms.TextBox textBoxPasswordB;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.GroupBox groupBoxCheckAccess;
        private System.Windows.Forms.GroupBox groupBoxReading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWriteData;
        private System.Windows.Forms.Label labelSeekWarning;
    }
}

