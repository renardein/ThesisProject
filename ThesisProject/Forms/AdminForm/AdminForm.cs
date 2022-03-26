﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisProject.Modules.DatabaseAdapter;
using ThesisProject.Modules.Crypto;

namespace ThesisProject.Forms.AdminForm
{
    public partial class AdminForm : Form
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        string[] userRole = new string[] { "admin", "user" };

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            currentUserLabel.Text += Program.FormDataExchange.CurrentUser;
            usersGrid.DataSource = from p in db.User select new { Пользователь = p.Username, Роль = p.Role };
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void addUser_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(regUsername.Text) && !string.IsNullOrEmpty(regUsername.Text))
            {
                if (!isUserExists(regUsername.Text))
                {
                    if (regPassword.Text == regPasswordConfirm.Text)
                    {
                        string pwd_hash = Crypto.GetMD5(regPassword.Text);
                        string role = userRole[regUserRole.SelectedIndex];
                        var newUser = new User
                        {
                            Username = regUsername.Text,
                            Password = pwd_hash,
                            Role = role
                        };
                        db.User.InsertOnSubmit(newUser);
                        db.SubmitChanges();
                        DialogResult result = MessageBox.Show("Пользователь добавлен", "Системное сообщение", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            UpdateUsersList();
                        }

                    }
                    else
                        MessageBox.Show("Пароли не совпадают");
                }
                else
                {
                    MessageBox.Show("Пользователь существует");
                }
            }
            else
            {
                MessageBox.Show("Проверьте поля");
            }
        }
        private bool isUserExists(string username)
        {
            var getUserFromDb = from c in db.User
                                where c.Username == username
                                select c;
            if (getUserFromDb.Count() == 1)
                return true;
            else
                return false;
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form2, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }
        private void UpdateUsersList()
        {
            usersGrid.DataSource = from p in db.User select new { Пользователь = p.Username, Роль = p.Role };
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rmUserButton_Click(object sender, EventArgs e)
        {
            string rmuser = usersGrid.CurrentCell.Value.ToString();
            DialogResult userDeleteResult = MessageBox.Show("Вы уверены что хотите удалить пользователя "+ rmuser+ "?", "Системное сообщение", MessageBoxButtons.YesNo);
            if (userDeleteResult == DialogResult.Yes)
            {
                User objUser = db.User.Single(user => user.Username == rmuser);
                db.User.DeleteOnSubmit(objUser);
                db.SubmitChanges();
                UpdateUsersList();
            }
        }
    }
}
