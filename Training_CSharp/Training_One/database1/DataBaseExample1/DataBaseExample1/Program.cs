using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseExample1
{
    class Program
    {
       
		static void Main(string[] args)
		{
			//1. Connect
			//1.1 Connection string
			string sqlSt = "SELECT companyid, companyname FROM Company";
			string connectionString = "Data Source=NEELAKSHI\\SQLEXPRESS01;Initial Catalog=db_shopon1;Integrated Security=True";
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				Console.WriteLine("Connected");
				//2. Execute
				SqlCommand command = new SqlCommand(sqlSt, con);
				SqlDataReader data = command.ExecuteReader();
				//3. Display
				while (data.Read())
				{
					Console.WriteLine(data["companyid"] + " \t " + data["companyname"]);
				}
			}
		}

	}
}
