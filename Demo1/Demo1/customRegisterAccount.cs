using System;
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
    public partial class customRegisterAccount : UserControl
    {
        public customRegisterAccount()
        {
            InitializeComponent();
        }

        public event EventHandler action_btnCancel_Clicked;
        public event EventHandler action_btnGoLogin_Clicked;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (action_btnCancel_Clicked != null)
                action_btnCancel_Clicked(this, null);
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            if (action_btnGoLogin_Clicked != null)
                action_btnGoLogin_Clicked(this, null);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //check user 
            //check pass
            //...
            
        }
    }
}
