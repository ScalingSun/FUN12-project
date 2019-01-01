using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FUN12
{
   public class Category
    {
        public int id { get; private set; }
        public string CategoryName { get; private set; }
        public int categoryID { get; private set; }
        public Category(int id, string CategoryName, int category)
        {
            this.id = id;
            this.CategoryName = CategoryName;
            this.categoryID = category;
        }
        public Category()
        {

        }
        public List<Category> GetCategories()
        {
            SQLConnection getCategory = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("SELECT * FROM Category", getCategory.conn))
            {
                getCategory.conn.Open();
                SqlDataReader reader = connection.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                List<Category> categorylist = new List<Category>();

                while (reader.Read())
                {
                    
                    int id = reader.GetInt32(0);
                    string CategoryName = reader.GetString(1);
                    int categoryID = reader.GetInt32(2);
                    Category test = new Category(id, CategoryName, categoryID);
                    categorylist.Add(test);
                }
                return categorylist;
            }

        }

    }
}
