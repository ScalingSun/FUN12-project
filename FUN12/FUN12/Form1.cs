using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUN12
{
    public partial class AanvraagAppLogin : Form
    {
        public AanvraagAppLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            Person Login = new Person();
            User Userdata = Login.LoginQuery(username, password);
            if(Userdata != null)
            {
                this.Hide();
                ProfileForm frm = new ProfileForm(Userdata);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Foutieve login!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void AanvraagAppLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
