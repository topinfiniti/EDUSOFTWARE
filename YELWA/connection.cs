using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace YELWA
{
    class connection
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataAdapter sda;
        public string pkk;

        public void Connection()
        {
            con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
            con.Open();
        }

        public void dataSend(string Mysql)
        {
            try
            {
                Connection();
                cmd = new MySqlCommand(Mysql, con);
                cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception ex)
            {
                pkk = "Please check your data";
            }
            con.Close();
        }

        public void dataGet(string Mysql)
        {
            try
            {
                Connection();
                sda = new MySqlDataAdapter(Mysql, con);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
