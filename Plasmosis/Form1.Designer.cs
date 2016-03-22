namespace Plasmosis
{
    partial class frmClassical
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
            this.classicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symmetricEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherEncryptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.radCaesar = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.radAffine = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicalToolStripMenuItem,
            this.symmetricEncryptionToolStripMenuItem,
            this.hashingToolStripMenuItem,
            this.otherEncryptionsToolStripMenuItem});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // classicalToolStripMenuItem
            // 
            this.classicalToolStripMenuItem.Name = "classicalToolStripMenuItem";
            this.classicalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.classicalToolStripMenuItem.Text = "Classical";
            // 
            // symmetricEncryptionToolStripMenuItem
            // 
            this.symmetricEncryptionToolStripMenuItem.Name = "symmetricEncryptionToolStripMenuItem";
            this.symmetricEncryptionToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.symmetricEncryptionToolStripMenuItem.Text = "Modern";
            // 
            // hashingToolStripMenuItem
            // 
            this.hashingToolStripMenuItem.Name = "hashingToolStripMenuItem";
            this.hashingToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hashingToolStripMenuItem.Text = "Hashing";
            // 
            // otherEncryptionsToolStripMenuItem
            // 
            this.otherEncryptionsToolStripMenuItem.Name = "otherEncryptionsToolStripMenuItem";
            this.otherEncryptionsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.otherEncryptionsToolStripMenuItem.Text = "Other";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.howToToolStripMenuItem.Text = "How-To";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Location = new System.Drawing.Point(0, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(358, 200);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Location = new System.Drawing.Point(-1, 272);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(359, 13);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.btnDecrypt);
            this.grpCipher.Controls.Add(this.btnEncrypt);
            this.grpCipher.Controls.Add(this.radAffine);
            this.grpCipher.Controls.Add(this.radCaesar);
            this.grpCipher.Location = new System.Drawing.Point(0, 291);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(360, 173);
            this.grpCipher.TabIndex = 6;
            this.grpCipher.TabStop = false;
            this.grpCipher.Text = "Cipher";
            // 
            // radCaesar
            // 
            this.radCaesar.AutoSize = true;
            this.radCaesar.Location = new System.Drawing.Point(12, 48);
            this.radCaesar.Name = "radCaesar";
            this.radCaesar.Size = new System.Drawing.Size(58, 17);
            this.radCaesar.TabIndex = 0;
            this.radCaesar.TabStop = true;
            this.radCaesar.Text = "Caesar";
            this.radCaesar.UseVisualStyleBackColor = true;
            this.radCaesar.CheckedChanged += new System.EventHandler(this.radCaesar_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Location = new System.Drawing.Point(364, 47);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(224, 384);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // radAffine
            // 
            this.radAffine.AutoSize = true;
            this.radAffine.Location = new System.Drawing.Point(12, 25);
            this.radAffine.Name = "radAffine";
            this.radAffine.Size = new System.Drawing.Size(52, 17);
            this.radAffine.TabIndex = 1;
            this.radAffine.TabStop = true;
            this.radAffine.Text = "Affine";
            this.radAffine.UseVisualStyleBackColor = true;
            this.radAffine.CheckedChanged += new System.EventHandler(this.radAffine_CheckedChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(117, 139);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 28);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(240, 139);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(118, 28);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // frmClassical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(588, 468);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmClassical";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plasmosis - Make Encryption Great Again   lol jk";
            this.Load += new System.EventHandler(this.frmClassical_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCipher.ResumeLayout(false);
            this.grpCipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem symmetricEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherEncryptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.ToolStripMenuItem classicalToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.RadioButton radCaesar;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radAffine;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

