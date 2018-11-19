using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using database_test.database;
using System.Windows.Forms;

namespace database_test.models
{
	class Users
	{
		
		//attributes
		public int id { get; private set; }
		public String username { get; private set; }
		public String password { get; private set; }

		public Users(int id, string username, string password)
		{
			this.id = id;
			this.username = username;
			this.password = password;
		}

		public Users()
		{
		}

		public static  List<Users> getUsers()
		{
			List<Users> users = new List<Users>();

			//fetch data
			String query =	"SELECT * " +
							"FROM users";
			var record = DB.getData(query);

			while (record.Read())
			{
				int id = (int)record["id"];
				String username = record["username"].ToString();
				String password = record["password"].ToString();

				Users u = new Users(id, username, password);

				users.Add(u);
			}

			return users;
		}

		public static void insert(string u, string p)
		{
			String query = String.Format("INSERT INTO USERS (username, password)" +
										"VALUES('{0}', '{1}')", u, p);
			if(DB.putData(query) > 0)
			{
				Console.WriteLine("insert ok");
			}
			else
			{
				MessageBox.Show("Somthing went Wrong \n try again");
			}
		}

		public void update(string u, string p)
		{
			String query = String.Format("UPDATE users " +
										"SET username = '{0}', password = '{1}' " +
										"WHERE id = '{2}'", u, p, id);
			if (DB.putData(query) > 0)
			{
				Console.WriteLine("insert ok");
			}
			else
			{
				MessageBox.Show("Somthing went Wrong \n try again");
			}
		}
	}
}
