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
    public partial class ProfileForm : Form
    {
       private User userData;
        
        public ProfileForm(User userdata)
        {
            this.userData = userdata;
            InitializeComponent();
            label3.Text = "Hallo, " + userData.firstname;
            label4.Text = "Wat informatie over: " + userData.firstname;
            label5.Text = "Achternaam: " + userData.lastname;
            label6.Text = "Gebruikersnaam: " + userData.username;
            label11.Text = "Wachtwoord: " + userData.password;

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestForm frm = new RequestForm(userData);
            frm.Show();
        }

        private void btnHistorie_Click(object sender, EventArgs e)
        {
            HistoryForm HistoryForm = new HistoryForm(userData);
            this.Hide();
            HistoryForm.Show();
        }
    }
}
