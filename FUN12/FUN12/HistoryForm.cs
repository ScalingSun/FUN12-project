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
    public partial class HistoryForm : Form
    {
        Person UserLend = new Person();
        int ProductTopLocation = 80;
        int Productleftlocation = 80;
        int startTopLocation = 80;
        int startLeftlocation = 240;

        public HistoryForm(User userdata)
        {
            InitializeComponent();
            lblFirstName.Text = "Welkom, " + userdata.firstname;
            List<Lend> List = new List<Lend>();
            List = UserLend.UserLend(userdata.id);
            Product ProductName = new Product();
            foreach(Lend item in List)
            {
                List <Product> Name = ProductName.GetProduct(item.productid);

                Label productnamelabel = new Label();
                productnamelabel.Left = Productleftlocation;
                productnamelabel.Top = ProductTopLocation;
                productnamelabel.Text = "Naam: " + Name.First().spulnaam;
                this.Controls.Add(productnamelabel);
                ProductTopLocation += productnamelabel.Height + 1;


                Label startlabel = new Label();
                startlabel.Left = startLeftlocation;
                startlabel.Top = startTopLocation;
                startlabel.Text = "startdatum: " + List.First().startdatum.ToString();
                this.Controls.Add(startlabel);
                startTopLocation += startlabel.Height + 1;
            }
        }
    }
}
