using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_test.models;
using database_test.database;


namespace database_test
{
	public partial class Form1 : Form
	{
		private Users currentUser;

		public Form1()
		{
			InitializeComponent();
			DB.initializedDB();
		}

		private void loadAll()
		{
			List<Users> users = Users.getUsers();

			//clear the list view
			lv_Users.Items.Clear();

			foreach(Users u in users)
			{
				ListViewItem item = new ListViewItem(new String[] { u.id.ToString(), u.username, u.password });
				item.Tag = u;

				lv_Users.Items.Add(item);
			}
		}

		private void btn_load_Click(object sender, EventArgs e)
		{
			loadAll();
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			String u = txt_username.Text;
			String p = txt_password.Text;

			if(String.IsNullOrEmpty(u) || String.IsNullOrEmpty(p))
			{
				MessageBox.Show("Field is empty!!!");
				return;
			}

			Users.insert(u, p);
			loadAll();

		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			String u = txt_username.Text;
			String p = txt_password.Text;

			if (String.IsNullOrEmpty(u) || String.IsNullOrEmpty(p))
			{
				MessageBox.Show("Field is empty!!!");
				return;
			}

			currentUser.update(u, p);
			loadAll();
		}

		

		private void lv_Users_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lv_Users.SelectedItems.Count > 0)
			{
				ListViewItem item = lv_Users.SelectedItems[0];

				currentUser = (Users)item.Tag;

				int id = currentUser.id;
				String u = currentUser.username;
				String p = currentUser.password;

				txt_username.Text = u;
				txt_id.Text = id.ToString();
				txt_password.Text = p;
			}
			
		}
	}
}
