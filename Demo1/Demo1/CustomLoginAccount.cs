﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class CustomLoginAccount : UserControl
    {
        public CustomLoginAccount()
        {
            InitializeComponent();
            
        }

        String user = "";
        String pass = "";

        public event EventHandler actionRequestLogin;
        private void CustomLoginAccount_Load(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.LightGray;
            txtUser.Text = "Username or Email";
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.LightGray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
        }

        public event EventHandler action_btnCancel_Clicked;
        public event EventHandler action_btnSignup_Clicked;
        public event EventHandler action_setUserName;

        public void btnCancel_Click(object sender, EventArgs e)
        {
            if (action_btnCancel_Clicked != null)
                action_btnCancel_Clicked(this, null);
        }
        
        public void test()
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPassword.Text;
            if (user.Equals("Username or Email") || pass.Equals("Password") || user.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("please input full information account to login!");
            }
            else
            {
                
                if (actionRequestLogin != null)
                    actionRequestLogin(this, null);
                //check account
                int index = Main.user.IndexOf(user);
                if (index < 0)
                {
                    MessageBox.Show("user invalid!");
                }
                else
                {
                    if (pass.Equals(Main.pass[index]))
                    {
                        MessageBox.Show("Login Successful!");
                        Main.currentUser = Main.user[index]; 
                        //set name btnLogin to btnLogout
                        
                        if(action_setUserName!=null)
                        {
                            action_setUserName(this,null);
                        }
                        Main.flag_admin = true;
                        if (Main.past_screen == Main._screen_UI.matrix)
                        { 
                            
                        }
                        if (action_btnCancel_Clicked != null)
                            action_btnCancel_Clicked(this, null);
                    }
                    else {
                        MessageBox.Show("password not correct!");
                    }
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (action_btnSignup_Clicked != null)
                action_btnSignup_Clicked(this, null);
        }
    }
}
