namespace database_test
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lv_Users = new System.Windows.Forms.ListView();
			this.list_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.list_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.list_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_load = new System.Windows.Forms.Button();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lv_Users
			// 
			this.lv_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_id,
            this.list_username,
            this.list_password});
			this.lv_Users.Cursor = System.Windows.Forms.Cursors.Default;
			this.lv_Users.Location = new System.Drawing.Point(12, 12);
			this.lv_Users.Name = "lv_Users";
			this.lv_Users.Size = new System.Drawing.Size(460, 224);
			this.lv_Users.TabIndex = 0;
			this.lv_Users.UseCompatibleStateImageBehavior = false;
			this.lv_Users.FullRowSelect = true;
			this.lv_Users.View = System.Windows.Forms.View.Details;
			this.lv_Users.SelectedIndexChanged += new System.EventHandler(this.lv_Users_SelectedIndexChanged);
			// 
			// list_id
			// 
			this.list_id.Text = "ID";
			// 
			// list_username
			// 
			this.list_username.Text = "User Name";
			this.list_username.Width = 200;
			// 
			// list_password
			// 
			this.list_password.Text = "Password";
			this.list_password.Width = 200;
			// 
			// btn_load
			// 
			this.btn_load.Location = new System.Drawing.Point(595, 12);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(184, 43);
			this.btn_load.TabIndex = 1;
			this.btn_load.Text = "load";
			this.btn_load.UseVisualStyleBackColor = true;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(595, 72);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(184, 44);
			this.btn_insert.TabIndex = 1;
			this.btn_insert.Text = "Insert";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(595, 138);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(184, 39);
			this.btn_update.TabIndex = 1;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(595, 195);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(184, 41);
			this.btn_delete.TabIndex = 1;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			
			// 
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.Location = new System.Drawing.Point(44, 271);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(21, 17);
			this.ID.TabIndex = 2;
			this.ID.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 305);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "user name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 342);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(219, 300);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(225, 22);
			this.txt_username.TabIndex = 3;
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(219, 337);
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(225, 22);
			this.txt_password.TabIndex = 3;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(219, 266);
			this.txt_id.Name = "txt_id";
			this.txt_id.ReadOnly = true;
			this.txt_id.Size = new System.Drawing.Size(225, 22);
			this.txt_id.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ID);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.lv_Users);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_Users;
		private System.Windows.Forms.ColumnHeader list_id;
		private System.Windows.Forms.ColumnHeader list_username;
		private System.Windows.Forms.ColumnHeader list_password;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label ID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.TextBox txt_password;
		private System.Windows.Forms.TextBox txt_id;
	}
}

