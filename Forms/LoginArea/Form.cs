using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisProject.Modules.Crypto;
using ThesisProject.Modules.DatabaseAdapter;
using ThesisProject.Modules.OpenForm;
using System.IO;

namespace ThesisProject
{
    public partial class LoginForm : Form
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {     
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           
        }
 

        private void exitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(authLoginBox.Text) && !string.IsNullOrEmpty(authPassBox.Text))
            {
                string pwd_md5 = Crypto.GetMD5(authPassBox.Text);
                var getUserFromDb = from c in db.User
                                    where (c.Username == authLoginBox.Text && c.Password == pwd_md5)
                                    select c;
                if (getUserFromDb.Count() == 1)
                {
                        var getRoleFromDb = from p in db.User where p.Username == authLoginBox.Text select p.Role;
                        string role = getRoleFromDb.First().ToString();
                        MessageBox.Show("Роль: " + role);
                    int selectedArea = authRoleBox.SelectedIndex();
                  
                }
                else
                {
                    MessageBox.Show("Пользователя не существует");
                }

            }
            else
            {
                MessageBox.Show("Проверьте заполненность полей");
            }
           
        }
    }
}
