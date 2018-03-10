namespace Demo1
{
    partial class CustomLoginAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomLoginAccount));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRecoverPass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.loginPanel.Controls.Add(this.btnSignup);
            this.loginPanel.Controls.Add(this.btnSignin);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.checkbox);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.txtUser);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(183, 154);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(525, 375);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnCancel.Size = new System.Drawing.Size(28, 29);
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
            this.btnRecoverPass.ButtonText = "Recover my password";
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
            this.btnRecoverPass.Location = new System.Drawing.Point(308, 322);
            this.btnRecoverPass.Name = "btnRecoverPass";
            this.btnRecoverPass.Normalcolor = System.Drawing.Color.White;
            this.btnRecoverPass.OnHovercolor = System.Drawing.Color.White;
            this.btnRecoverPass.OnHoverTextColor = System.Drawing.Color.CornflowerBlue;
            this.btnRecoverPass.selected = false;
            this.btnRecoverPass.Size = new System.Drawing.Size(163, 26);
            this.btnRecoverPass.TabIndex = 6;
            this.btnRecoverPass.Text = "Recover my password";
            this.btnRecoverPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecoverPass.Textcolor = System.Drawing.Color.Black;
            this.btnRecoverPass.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSignup
            // 
            this.btnSignup.Activecolor = System.Drawing.Color.Coral;
            this.btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignup.BorderRadius = 0;
            this.btnSignup.ButtonText = "Not a member? Sign up";
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignup.Iconimage = null;
            this.btnSignup.Iconimage_right = null;
            this.btnSignup.Iconimage_right_Selected = null;
            this.btnSignup.Iconimage_Selected = null;
            this.btnSignup.IconMarginLeft = 0;
            this.btnSignup.IconMarginRight = 0;
            this.btnSignup.IconRightVisible = true;
            this.btnSignup.IconRightZoom = 0D;
            this.btnSignup.IconVisible = true;
            this.btnSignup.IconZoom = 90D;
            this.btnSignup.IsTab = false;
            this.btnSignup.Location = new System.Drawing.Point(62, 322);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Normalcolor = System.Drawing.Color.White;
            this.btnSignup.OnHovercolor = System.Drawing.Color.White;
            this.btnSignup.OnHoverTextColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignup.selected = false;
            this.btnSignup.Size = new System.Drawing.Size(163, 26);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Not a member? Sign up";
            this.btnSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignup.Textcolor = System.Drawing.Color.Black;
            this.btnSignup.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSignin
            // 
            this.btnSignin.ActiveBorderThickness = 1;
            this.btnSignin.ActiveCornerRadius = 20;
            this.btnSignin.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnSignin.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignin.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnSignin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignin.BackColor = System.Drawing.Color.White;
            this.btnSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignin.BackgroundImage")));
            this.btnSignin.ButtonText = "Sign in";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignin.IdleBorderThickness = 1;
            this.btnSignin.IdleCornerRadius = 20;
            this.btnSignin.IdleFillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignin.IdleForecolor = System.Drawing.Color.White;
            this.btnSignin.IdleLineColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignin.Location = new System.Drawing.Point(62, 259);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(409, 63);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remember me";
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
            this.checkbox.Location = new System.Drawing.Point(62, 230);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(20, 20);
            this.checkbox.TabIndex = 2;
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
            this.txtPassword.Location = new System.Drawing.Point(62, 163);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 51);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
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
            this.txtUser.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
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
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // CustomLoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginPanel);
            this.Name = "CustomLoginAccount";
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.CustomLoginAccount_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignin;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox checkbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecoverPass;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignup;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
