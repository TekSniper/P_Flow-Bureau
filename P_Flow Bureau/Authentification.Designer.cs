namespace P_Flow_Bureau
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLogin = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPwd = new Telerik.WinControls.UI.RadTextBox();
            this.btCnx = new Telerik.WinControls.UI.RadButton();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.tbLogin.Location = new System.Drawing.Point(12, 127);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(278, 23);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.ThemeName = "Crystal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.tbPwd.Location = new System.Drawing.Point(12, 191);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(278, 23);
            this.tbPwd.TabIndex = 2;
            this.tbPwd.ThemeName = "Crystal";
            // 
            // btCnx
            // 
            this.btCnx.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.btCnx.Location = new System.Drawing.Point(12, 285);
            this.btCnx.Name = "btCnx";
            this.btCnx.Size = new System.Drawing.Size(278, 48);
            this.btCnx.TabIndex = 4;
            this.btCnx.Text = "Connexion";
            this.btCnx.ThemeName = "Crystal";
            this.btCnx.Click += new System.EventHandler(this.btCnx_Click);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.radCheckBox1.Location = new System.Drawing.Point(12, 233);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(175, 18);
            this.radCheckBox1.TabIndex = 3;
            this.radCheckBox1.Text = "Afficher le mot de passe";
            this.radCheckBox1.ThemeName = "Crystal";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radCheckBox1.CheckStateChanged += new System.EventHandler(this.radCheckBox1_CheckStateChanged);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 365);
            this.Controls.Add(this.radCheckBox1);
            this.Controls.Add(this.btCnx);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authentification";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.ThemeName = "Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authentification_FormClosing);
            this.Load += new System.EventHandler(this.Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCnx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadTextBox tbLogin;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox tbPwd;
        private Telerik.WinControls.UI.RadButton btCnx;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
