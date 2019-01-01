using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FUN12
{
    public class Product
    {

        public int id { get; private set; }
        public string spulnaam { get; private set; }
        public int categoryID { get; private set; }
        public DateTime startdatum { get; private set; }
        public DateTime einddatum { get; private set; }
        public int aantal { get; private set; }
        public Product(int id, string spulnaam, int category, DateTime startdatum, DateTime einddatum, int aantal)
        {
            this.id = id;
            this.spulnaam = spulnaam;
            this.categoryID = category;
            this.startdatum = startdatum;
            this.einddatum = einddatum;
            this.aantal = aantal;
        }
        public Product()
        {

        }
        public static List<Product> GetProducts(int id)
        {
            SQLConnection getProduct = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("SELECT * FROM Product WHERE CategoryID = @categoryID", getProduct.conn))
            {
                getProduct.conn.Open();
                connection.Parameters.Add(new SqlParameter("categoryID", id));
                SqlDataReader reader = connection.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                List<Product> productlist = new List<Product>();

                while (reader.Read())
                {

                    int ID = reader.GetInt32(0);
                    string spulnaam = reader.GetString(1);
                    int categoryID = reader.GetInt32(2);
                    DateTime startdatum = reader.GetDateTime(3);
                    DateTime einddatum = reader.GetDateTime(4);
                    int aantal = reader.GetInt32(5);
                    Product test = new Product(ID, spulnaam, categoryID, startdatum, einddatum, aantal);
                    productlist.Add(test);
                }
                return productlist;
            }

        }
        public static List<Product> GetProductDetails(string spulnaam)
        {
            SQLConnection getProduct = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("SELECT * FROM Product WHERE spulnaam = @spulnaam", getProduct.conn))
            {
                getProduct.conn.Open();
                
                connection.Parameters.Add(new SqlParameter("spulnaam", spulnaam));
                SqlDataReader reader = connection.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                List<Product> productlist = new List<Product>();

                while (reader.Read())
                {

                    int ID = reader.GetInt32(0);
                    string productnaam = reader.GetString(1);
                    int categoryID = reader.GetInt32(2);
                    DateTime startdatum = reader.GetDateTime(3);
                    DateTime einddatum = reader.GetDateTime(4);
                    int aantal = reader.GetInt32(5);
                    Product test = new Product(ID, productnaam, categoryID, startdatum, einddatum, aantal);
                    productlist.Add(test);
                }
                return productlist;
            }
        }
        public void Lend(DateTime startdatum, DateTime einddatum ,int item, int userID)
        {
            SQLConnection LendProduct = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("INSERT INTO Lend (StartDate, EndDate, ProductID, userID) VALUES (@startdatum, @einddatum, @item, @userID) ", LendProduct.conn))
            {
                LendProduct.conn.Open();
                connection.Parameters.Add(new SqlParameter("startdatum", startdatum));
                connection.Parameters.Add(new SqlParameter("einddatum", einddatum));
                connection.Parameters.Add(new SqlParameter("item", item));
                connection.Parameters.Add(new SqlParameter("userID", userID));
                connection.ExecuteNonQuery();
                LendProduct.conn.Close();
                Lend lend = new Lend();
                lend.Remove1AtLend(item);
            }
        }
    }
}
