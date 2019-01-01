﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FUN12
{
    public class Lend
    {
        int id;
        int productid;
        DateTime startdatum;
        DateTime einddatum;
        int UserID;
        int aantal;
        List<Lend> LendList = new List<Lend>();

        public Lend(int aantal)
        {
            this.id = aantal;
        }
        public Lend()
        {

        }
        public List<Lend> SpecificItemFromLend(int item)
        {
            SQLConnection LendLeft = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("SELECT aantal FROM product WHERE id = @item", LendLeft.conn))
            {
                LendLeft.conn.Open();
                connection.Parameters.Add(new SqlParameter("item", item));
                connection.ExecuteNonQuery();


                SqlDataReader reader = connection.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                while (reader.Read())
                {

                    int aantal = reader.GetInt32(0);
                    Lend test = new Lend(aantal);
                    LendList.Add(test);
                }
                LendLeft.conn.Close();
                return LendList;

            }
        }
        public void Remove1AtLend(int item)
        {
            SpecificItemFromLend(item);
            foreach(var banaan in LendList)
            Console.WriteLine(banaan.aantal);
        }
    }
}
