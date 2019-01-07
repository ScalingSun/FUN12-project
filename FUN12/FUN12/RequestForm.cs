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
    public partial class RequestForm : Form
    {
        List<Category> categorylist = new List <Category>();
        List<Product> productlist = new List<Product>();
        Category category = new Category();
        Product producten = new Product();
        Person person = new Person();
        User userdata;
        public RequestForm(User userData)
        {
            this.userdata = userData;
            InitializeComponent();
            lblFirstName.Text = userData.firstname;
            int categorytop = 50;
            int categoryleft = 12;
           categorylist = category.GetCategories();
            


            foreach (Category category in categorylist)
            {
                Button button = new Button();
                button.Left = categoryleft;
                button.Top = categorytop;
                button.Click += Button_Click;
                button.Name = category.CategoryName;
                button.Text = category.CategoryName;
                this.Controls.Add(button);
                categorytop += button.Height + 2;
            }

        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lbxProducts.Items.Clear();

            switch(b.Name)
            
            {
                case "sjormaterialen":
                    productlist = Product.GetProducts(1);
                    break;
                case "tenten":
                    productlist = Product.GetProducts(2);
                    break;
                case "kampspullen":
                    productlist = Product.GetProducts(3);
                    break;
                case "overige materialen":
                    productlist = Product.GetProducts(4);
                    break;
            }

            foreach (Product product in productlist)
            {
                lbxProducts.Items.Add(product.spulnaam);
            }
            
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }

        private void lbxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string send = lbxProducts.SelectedItem.ToString();
            List <Product> productdetails = Product.GetProductDetails(send);
            lblAmount.Text = "Aantal Over: " + productdetails[0].aantal;
            lblMaterialName.Text = productdetails[0].spulnaam;
            Button Request = new Button();
            Request.Text = "Vraag aan!";
            Request.Name = "btnRequest";
            Request.Top = 400;
            Request.Left = 550;
            Request.Click += Request_Click;
            this.Controls.Add(Request);
        }

        private void Request_Click(object sender, EventArgs e)
        {
            string send = lbxProducts.SelectedItem.ToString();
            List<Product> details = Product.GetProductDetails(send);
            int itemID = details[0].id;
            DateTime startdatum = this.dateTimePicker1.Value.Date;
            DateTime einddatum = dateTimePicker2.Value.Date;
            int userID = userdata.id;
            producten.Lend(startdatum, einddatum, itemID,userID);
            MessageBox.Show("I hope it worked yes");
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
