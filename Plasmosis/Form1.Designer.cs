namespace Plasmosis
{
    partial class Form1
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
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.symmetricEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherEncryptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symmetricEncryptionToolStripMenuItem,
            this.hashingToolStripMenuItem,
            this.otherEncryptionsToolStripMenuItem});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.howToToolStripMenuItem.Text = "How to";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.howToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // symmetricEncryptionToolStripMenuItem
            // 
            this.symmetricEncryptionToolStripMenuItem.Name = "symmetricEncryptionToolStripMenuItem";
            this.symmetricEncryptionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.symmetricEncryptionToolStripMenuItem.Text = "Symmetric Encryption";
            // 
            // hashingToolStripMenuItem
            // 
            this.hashingToolStripMenuItem.Name = "hashingToolStripMenuItem";
            this.hashingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.hashingToolStripMenuItem.Text = "Hashing";
            // 
            // otherEncryptionsToolStripMenuItem
            // 
            this.otherEncryptionsToolStripMenuItem.Name = "otherEncryptionsToolStripMenuItem";
            this.otherEncryptionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.otherEncryptionsToolStripMenuItem.Text = "Other Encryptions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(588, 468);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plasmosis - Make Encryption Great Again   lol jk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem symmetricEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherEncryptionsToolStripMenuItem;
    }
}

