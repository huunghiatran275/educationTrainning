namespace Demo1
{
    partial class customRegisterAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customRegisterAccount));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRecoverPass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGoLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtConfirmPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.btnCancel);
            this.loginPanel.Controls.Add(this.btnRecoverPass);
            this.loginPanel.Controls.Add(this.btnGoLogin);
            this.loginPanel.Controls.Add(this.btnRegister);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.checkbox);
            this.loginPanel.Controls.Add(this.txtConfirmPass);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.txtUser);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(183, 140);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(525, 429);
            this.loginPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(494, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 43);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 10;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRecoverPass
            // 
            this.btnRecoverPass.Activecolor = System.Drawing.Color.Coral;
            this.btnRecoverPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecoverPass.BackColor = System.Drawing.Color.White;
            this.btnRecoverPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecoverPass.BorderRadius = 0;
            this.btnRecoverPass.ButtonText = "Nothing";
            this.btnRecoverPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverPass.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecoverPass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecoverPass.Iconimage = null;
            this.btnRecoverPass.Iconimage_right = null;
            this.btnRecoverPass.Iconimage_right_Selected = null;
            this.btnRecoverPass.Iconimage_Selected = null;
            this.btnRecoverPass.IconMarginLeft = 0;
            this.btnRecoverPass.IconMarginRight = 0;
            this.btnRecoverPass.IconRightVisible = true;
            this.btnRecoverPass.IconRightZoom = 0D;
            this.btnRecoverPass.IconVisible = true;
            this.btnRecoverPass.IconZoom = 90D;
            this.btnRecoverPass.IsTab = false;
            this.btnRecoverPass.Location = new System.Drawing.Point(308, 381);
            this.btnRecoverPass.Name = "btnRecoverPass";
            this.btnRecoverPass.Normalcolor = System.Drawing.Color.White;
            this.btnRecoverPass.OnHovercolor = System.Drawing.Color.White;
            this.btnRecoverPass.OnHoverTextColor = System.Drawing.Color.CornflowerBlue;
            this.btnRecoverPass.selected = false;
            this.btnRecoverPass.Size = new System.Drawing.Size(163, 33);
            this.btnRecoverPass.TabIndex = 6;
            this.btnRecoverPass.Text = "Nothing";
            this.btnRecoverPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecoverPass.Textcolor = System.Drawing.Color.Black;
            this.btnRecoverPass.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.Activecolor = System.Drawing.Color.Coral;
            this.btnGoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoLogin.BackColor = System.Drawing.Color.White;
            this.btnGoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoLogin.BorderRadius = 0;
            this.btnGoLogin.ButtonText = "Already registered and Sign in";
            this.btnGoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnGoLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGoLogin.Iconimage = null;
            this.btnGoLogin.Iconimage_right = null;
            this.btnGoLogin.Iconimage_right_Selected = null;
            this.btnGoLogin.Iconimage_Selected = null;
            this.btnGoLogin.IconMarginLeft = 0;
            this.btnGoLogin.IconMarginRight = 0;
            this.btnGoLogin.IconRightVisible = true;
            this.btnGoLogin.IconRightZoom = 0D;
            this.btnGoLogin.IconVisible = true;
            this.btnGoLogin.IconZoom = 90D;
            this.btnGoLogin.IsTab = false;
            this.btnGoLogin.Location = new System.Drawing.Point(62, 381);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.Normalcolor = System.Drawing.Color.White;
            this.btnGoLogin.OnHovercolor = System.Drawing.Color.White;
            this.btnGoLogin.OnHoverTextColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoLogin.selected = false;
            this.btnGoLogin.Size = new System.Drawing.Size(209, 33);
            this.btnGoLogin.TabIndex = 6;
            this.btnGoLogin.Text = "Already registered and Sign in";
            this.btnGoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoLogin.Textcolor = System.Drawing.Color.Black;
            this.btnGoLogin.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.Location = new System.Drawing.Point(62, 321);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(409, 63);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show password";
            // 
            // checkbox
            // 
            this.checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkbox.Checked = true;
            this.checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkbox.ForeColor = System.Drawing.Color.White;
            this.checkbox.Location = new System.Drawing.Point(62, 292);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(20, 20);
            this.checkbox.TabIndex = 2;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPass.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtConfirmPass.BorderColorIdle = System.Drawing.Color.CornflowerBlue;
            this.txtConfirmPass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtConfirmPass.BorderThickness = 3;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmPass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtConfirmPass.isPassword = false;
            this.txtConfirmPass.Location = new System.Drawing.Point(62, 222);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(409, 51);
            this.txtConfirmPass.TabIndex = 1;
            this.txtConfirmPass.Text = "Confirm Password";
            this.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.CornflowerBlue;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPassword.isPassword = false;
            this.txtPassword.Location = new System.Drawing.Point(62, 156);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 51);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUser.BorderColorIdle = System.Drawing.Color.CornflowerBlue;
            this.txtUser.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtUser.BorderThickness = 3;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUser.isPassword = false;
            this.txtUser.Location = new System.Drawing.Point(62, 90);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(409, 51);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Username or Email";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.loginPanel;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // customRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customRegisterAccount";
            this.Size = new System.Drawing.Size(900, 642);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecoverPass;
        private Bunifu.Framework.UI.BunifuFlatButton btnGoLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtUser;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtConfirmPass;
    }
}
