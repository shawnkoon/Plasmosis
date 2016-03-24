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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassical));
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
            this.longKey = new System.Windows.Forms.TextBox();
            this.grpCipher = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.radAffine = new System.Windows.Forms.RadioButton();
            this.radCaesar = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.shortKey1 = new System.Windows.Forms.TextBox();
            this.shortKey2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpCipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicalToolStripMenuItem,
            this.symmetricEncryptionToolStripMenuItem,
            this.hashingToolStripMenuItem,
            this.otherEncryptionsToolStripMenuItem});
            this.selectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // classicalToolStripMenuItem
            // 
            this.classicalToolStripMenuItem.Name = "classicalToolStripMenuItem";
            this.classicalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.classicalToolStripMenuItem.Text = "Classical";
            // 
            // symmetricEncryptionToolStripMenuItem
            // 
            this.symmetricEncryptionToolStripMenuItem.Name = "symmetricEncryptionToolStripMenuItem";
            this.symmetricEncryptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.symmetricEncryptionToolStripMenuItem.Text = "Modern";
            // 
            // hashingToolStripMenuItem
            // 
            this.hashingToolStripMenuItem.Name = "hashingToolStripMenuItem";
            this.hashingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hashingToolStripMenuItem.Text = "Hashing";
            // 
            // otherEncryptionsToolStripMenuItem
            // 
            this.otherEncryptionsToolStripMenuItem.Name = "otherEncryptionsToolStripMenuItem";
            this.otherEncryptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherEncryptionsToolStripMenuItem.Text = "Other";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToToolStripMenuItem.Text = "How-To";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(132, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtInput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(7, 117);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(358, 158);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(158, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // longKey
            // 
            this.longKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.longKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.longKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.longKey.Location = new System.Drawing.Point(59, 310);
            this.longKey.Name = "longKey";
            this.longKey.Size = new System.Drawing.Size(257, 17);
            this.longKey.TabIndex = 5;
            this.longKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.longKey.TextChanged += new System.EventHandler(this.longKey_TextChanged);
            // 
            // grpCipher
            // 
            this.grpCipher.Controls.Add(this.btnDecrypt);
            this.grpCipher.Controls.Add(this.btnEncrypt);
            this.grpCipher.Controls.Add(this.radAffine);
            this.grpCipher.Controls.Add(this.radCaesar);
            this.grpCipher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpCipher.Location = new System.Drawing.Point(5, 361);
            this.grpCipher.Name = "grpCipher";
            this.grpCipher.Size = new System.Drawing.Size(360, 173);
            this.grpCipher.TabIndex = 6;
            this.grpCipher.TabStop = false;
            this.grpCipher.Text = "Cipher";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Brown;
            this.btnDecrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(240, 139);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(118, 28);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEncrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEncrypt.Location = new System.Drawing.Point(117, 139);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 28);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // radAffine
            // 
            this.radAffine.AutoSize = true;
            this.radAffine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAffine.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radAffine.Location = new System.Drawing.Point(12, 25);
            this.radAffine.Name = "radAffine";
            this.radAffine.Size = new System.Drawing.Size(69, 24);
            this.radAffine.TabIndex = 1;
            this.radAffine.TabStop = true;
            this.radAffine.Text = "Affine";
            this.radAffine.UseVisualStyleBackColor = true;
            this.radAffine.CheckedChanged += new System.EventHandler(this.radAffine_CheckedChanged);
            // 
            // radCaesar
            // 
            this.radCaesar.AutoSize = true;
            this.radCaesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCaesar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radCaesar.Location = new System.Drawing.Point(12, 59);
            this.radCaesar.Name = "radCaesar";
            this.radCaesar.Size = new System.Drawing.Size(78, 24);
            this.radCaesar.TabIndex = 0;
            this.radCaesar.TabStop = true;
            this.radCaesar.Text = "Caesar";
            this.radCaesar.UseVisualStyleBackColor = true;
            this.radCaesar.CheckedChanged += new System.EventHandler(this.radCaesar_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutput.Location = new System.Drawing.Point(369, 117);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(224, 377);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(453, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(369, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.infoLabel.Location = new System.Drawing.Point(36, 338);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(303, 20);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "Please Choose One of the Following Cipher!";
            // 
            // shortKey1
            // 
            this.shortKey1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.shortKey1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shortKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortKey1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.shortKey1.Location = new System.Drawing.Point(59, 310);
            this.shortKey1.Name = "shortKey1";
            this.shortKey1.Size = new System.Drawing.Size(101, 17);
            this.shortKey1.TabIndex = 11;
            this.shortKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shortKey1.TextChanged += new System.EventHandler(this.shortKey1_TextChanged);
            // 
            // shortKey2
            // 
            this.shortKey2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.shortKey2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shortKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortKey2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.shortKey2.Location = new System.Drawing.Point(212, 310);
            this.shortKey2.Name = "shortKey2";
            this.shortKey2.Size = new System.Drawing.Size(104, 17);
            this.shortKey2.TabIndex = 12;
            this.shortKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shortKey2.TextChanged += new System.EventHandler(this.shortKey2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(165, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "Classical";
            // 
            // frmClassical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(601, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shortKey2);
            this.Controls.Add(this.shortKey1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.grpCipher);
            this.Controls.Add(this.longKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmClassical";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plasmosis - Friendly encryption";
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
        private System.Windows.Forms.TextBox longKey;
        private System.Windows.Forms.ToolStripMenuItem classicalToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCipher;
        private System.Windows.Forms.RadioButton radCaesar;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radAffine;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox shortKey1;
        private System.Windows.Forms.TextBox shortKey2;
        private System.Windows.Forms.Label label4;
    }
}

