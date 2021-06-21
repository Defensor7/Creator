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
            this.toolUc = new Creator.Tool.Tool();
            this.SuspendLayout();
            // 
            // toolUc
            // 
            this.toolUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolUc.Location = new System.Drawing.Point(0, 0);
            this.toolUc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolUc.Name = "toolUc";
            this.toolUc.Size = new System.Drawing.Size(782, 548);
            this.toolUc.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 548);
            this.Controls.Add(this.toolUc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Creator CRT-570 + Creator CRT-601 Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private Tool toolUc;
    }
}

