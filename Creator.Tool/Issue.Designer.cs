namespace Creator.Tool
{
    partial class Issue
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
            this.buttonUniqueGenerate = new System.Windows.Forms.Button();
            this.groupBoxIssueNewCard = new System.Windows.Forms.GroupBox();
            this.labelBcLength = new System.Windows.Forms.Label();
            this.numericUpDownBarcodeLength = new System.Windows.Forms.NumericUpDown();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelPasswordB = new System.Windows.Forms.Label();
            this.textBoxPasswordB = new System.Windows.Forms.TextBox();
            this.labelPasswordA = new System.Windows.Forms.Label();
            this.textBoxPasswordA = new System.Windows.Forms.TextBox();
            this.labelCardCount = new System.Windows.Forms.Label();
            this.numericUpDownCardCount = new System.Windows.Forms.NumericUpDown();
            this.labelSector = new System.Windows.Forms.Label();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.labelBlock = new System.Windows.Forms.Label();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
            this.groupBoxCom = new System.Windows.Forms.GroupBox();
            this.buttonComRefresh = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBoxIssueNewCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarcodeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCardCount)).BeginInit();
            this.groupBoxCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUniqueGenerate
            // 
            this.buttonUniqueGenerate.Location = new System.Drawing.Point(263, 214);
            this.buttonUniqueGenerate.Name = "buttonUniqueGenerate";
            this.buttonUniqueGenerate.Size = new System.Drawing.Size(187, 31);
            this.buttonUniqueGenerate.TabIndex = 0;
            this.buttonUniqueGenerate.Text = "Generate";
            this.buttonUniqueGenerate.UseVisualStyleBackColor = true;
            this.buttonUniqueGenerate.Click += new System.EventHandler(this.buttonUniqueGenerate_Click);
            // 
            // groupBoxIssueNewCard
            // 
            this.groupBoxIssueNewCard.Controls.Add(this.labelBcLength);
            this.groupBoxIssueNewCard.Controls.Add(this.numericUpDownBarcodeLength);
            this.groupBoxIssueNewCard.Controls.Add(this.labelPasswordB);
            this.groupBoxIssueNewCard.Controls.Add(this.buttonUniqueGenerate);
            this.groupBoxIssueNewCard.Controls.Add(this.textBoxPasswordB);
            this.groupBoxIssueNewCard.Controls.Add(this.labelPasswordA);
            this.groupBoxIssueNewCard.Controls.Add(this.textBoxPasswordA);
            this.groupBoxIssueNewCard.Controls.Add(this.labelCardCount);
            this.groupBoxIssueNewCard.Controls.Add(this.numericUpDownCardCount);
            this.groupBoxIssueNewCard.Controls.Add(this.labelSector);
            this.groupBoxIssueNewCard.Controls.Add(this.comboBoxSector);
            this.groupBoxIssueNewCard.Controls.Add(this.labelBlock);
            this.groupBoxIssueNewCard.Controls.Add(this.comboBoxBlock);
            this.groupBoxIssueNewCard.Location = new System.Drawing.Point(372, 12);
            this.groupBoxIssueNewCard.Name = "groupBoxIssueNewCard";
            this.groupBoxIssueNewCard.Size = new System.Drawing.Size(490, 264);
            this.groupBoxIssueNewCard.TabIndex = 1;
            this.groupBoxIssueNewCard.TabStop = false;
            this.groupBoxIssueNewCard.Text = "Card issue";
            // 
            // labelBcLength
            // 
            this.labelBcLength.AutoSize = true;
            this.labelBcLength.Location = new System.Drawing.Point(22, 174);
            this.labelBcLength.Name = "labelBcLength";
            this.labelBcLength.Size = new System.Drawing.Size(78, 25);
            this.labelBcLength.TabIndex = 32;
            this.labelBcLength.Text = "Length";
            // 
            // numericUpDownBarcodeLength
            // 
            this.numericUpDownBarcodeLength.Location = new System.Drawing.Point(101, 172);
            this.numericUpDownBarcodeLength.Name = "numericUpDownBarcodeLength";
            this.numericUpDownBarcodeLength.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownBarcodeLength.TabIndex = 31;
            this.numericUpDownBarcodeLength.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(12, 380);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(1096, 412);
            this.textBoxResult.TabIndex = 30;
            // 
            // labelPasswordB
            // 
            this.labelPasswordB.AutoSize = true;
            this.labelPasswordB.Location = new System.Drawing.Point(258, 98);
            this.labelPasswordB.Name = "labelPasswordB";
            this.labelPasswordB.Size = new System.Drawing.Size(126, 25);
            this.labelPasswordB.TabIndex = 29;
            this.labelPasswordB.Text = "Password B";
            // 
            // textBoxPasswordB
            // 
            this.textBoxPasswordB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordB.Location = new System.Drawing.Point(263, 128);
            this.textBoxPasswordB.MaxLength = 12;
            this.textBoxPasswordB.Name = "textBoxPasswordB";
            this.textBoxPasswordB.Size = new System.Drawing.Size(187, 31);
            this.textBoxPasswordB.TabIndex = 28;
            // 
            // labelPasswordA
            // 
            this.labelPasswordA.AutoSize = true;
            this.labelPasswordA.Location = new System.Drawing.Point(17, 98);
            this.labelPasswordA.Name = "labelPasswordA";
            this.labelPasswordA.Size = new System.Drawing.Size(126, 25);
            this.labelPasswordA.TabIndex = 27;
            this.labelPasswordA.Text = "Password A";
            // 
            // textBoxPasswordA
            // 
            this.textBoxPasswordA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordA.Location = new System.Drawing.Point(22, 128);
            this.textBoxPasswordA.MaxLength = 12;
            this.textBoxPasswordA.Name = "textBoxPasswordA";
            this.textBoxPasswordA.Size = new System.Drawing.Size(195, 31);
            this.textBoxPasswordA.TabIndex = 26;
            // 
            // labelCardCount
            // 
            this.labelCardCount.AutoSize = true;
            this.labelCardCount.Location = new System.Drawing.Point(22, 216);
            this.labelCardCount.Name = "labelCardCount";
            this.labelCardCount.Size = new System.Drawing.Size(69, 25);
            this.labelCardCount.TabIndex = 25;
            this.labelCardCount.Text = "Count";
            // 
            // numericUpDownCardCount
            // 
            this.numericUpDownCardCount.Location = new System.Drawing.Point(101, 214);
            this.numericUpDownCardCount.Name = "numericUpDownCardCount";
            this.numericUpDownCardCount.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownCardCount.TabIndex = 24;
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Location = new System.Drawing.Point(17, 48);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(74, 25);
            this.labelSector.TabIndex = 22;
            this.labelSector.Text = "Sector";
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(96, 40);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSector.TabIndex = 20;
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(258, 48);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(65, 25);
            this.labelBlock.TabIndex = 23;
            this.labelBlock.Text = "Block";
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Location = new System.Drawing.Point(329, 42);
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(121, 33);
            this.comboBoxBlock.TabIndex = 21;
            // 
            // groupBoxCom
            // 
            this.groupBoxCom.Controls.Add(this.buttonComRefresh);
            this.groupBoxCom.Controls.Add(this.comboBoxPorts);
            this.groupBoxCom.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCom.Name = "groupBoxCom";
            this.groupBoxCom.Size = new System.Drawing.Size(354, 181);
            this.groupBoxCom.TabIndex = 2;
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
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 804);
            this.Controls.Add(this.groupBoxCom);
            this.Controls.Add(this.groupBoxIssueNewCard);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Issue";
            this.Text = "Issue";
            this.groupBoxIssueNewCard.ResumeLayout(false);
            this.groupBoxIssueNewCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarcodeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCardCount)).EndInit();
            this.groupBoxCom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUniqueGenerate;
        private System.Windows.Forms.GroupBox groupBoxIssueNewCard;
        private System.Windows.Forms.GroupBox groupBoxCom;
        private System.Windows.Forms.Button buttonComRefresh;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.ComboBox comboBoxBlock;
        private System.Windows.Forms.Label labelCardCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCardCount;
        private System.Windows.Forms.Label labelPasswordB;
        private System.Windows.Forms.TextBox textBoxPasswordB;
        private System.Windows.Forms.Label labelPasswordA;
        private System.Windows.Forms.TextBox textBoxPasswordA;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelBcLength;
        private System.Windows.Forms.NumericUpDown numericUpDownBarcodeLength;
    }
}