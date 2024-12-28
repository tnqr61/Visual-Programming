namespace loginRegisterForm
{
    partial class ListForm
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
            this.getUsers = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // getUsers
            // 
            this.getUsers.Location = new System.Drawing.Point(411, 41);
            this.getUsers.Name = "getUsers";
            this.getUsers.Size = new System.Drawing.Size(225, 23);
            this.getUsers.TabIndex = 1;
            this.getUsers.Text = "Get All Users";
            this.getUsers.UseVisualStyleBackColor = true;
            this.getUsers.Click += new System.EventHandler(this.getUsers_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(401, 307);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(235, 23);
            this.deleteUser.TabIndex = 2;
            this.deleteUser.Text = "delete Selected User";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(401, 278);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(235, 23);
            this.updateUser.TabIndex = 3;
            this.updateUser.Text = "Update ";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(473, 182);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(163, 22);
            this.nameText.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name:";
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(473, 248);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(163, 22);
            this.passtext.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(473, 210);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(163, 22);
            this.emailtext.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Name,
            this.Email,
            this.Password});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(319, 289);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DisplayIndex = 3;
            this.id.Text = "Id";
            this.id.Width = 64;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Name";
            // 
            // Email
            // 
            this.Email.DisplayIndex = 1;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 73;
            // 
            // Password
            // 
            this.Password.DisplayIndex = 2;
            this.Password.Text = "passsword";
            this.Password.Width = 134;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.getUsers);
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getUsers;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader id;
    }
}