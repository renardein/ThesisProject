using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ThesisProject.Modules.Crypto;
using ThesisProject.Modules.DatabaseAdapter;
using ThesisProject.Modules.OpenForm;
using ThesisProject.Modules.TempData;

namespace ThesisProject.Forms.AdminForm
{
    public partial class AdminForm : Form
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        Tasks tsk = new Tasks();                                                                                
        string[] userRole = new string[] { "admin", "user" };

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            currentUserStrip.Text = TempData.CurrentUser;
            UpdateUsersList();
        }


        private void addUser_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(regUsername.Text) && !string.IsNullOrEmpty(regUsername.Text))
            {
                if (regUsername.Text == "karpovan" || regUsername.Text == "karpov" || regUsername.Text == "karpik")
                {
                    OpenForm.KarpikEgg();
                    return;
                }
                if (!tsk.isUserExists(regUsername.Text))
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
                    return;
                }
                else
                {
                    MessageBox.Show("Пользователь существует");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Проверьте поля");
                return;
            }
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

        private void rmUserButton_Click(object sender, EventArgs e)
        {
            string rmuser = usersGrid.CurrentCell.Value.ToString();
            DialogResult userDeleteResult = MessageBox.Show("Вы уверены что хотите удалить пользователя " + rmuser + "?", "Системное сообщение", MessageBoxButtons.YesNo);

            try
            {
                if (userDeleteResult == DialogResult.Yes)
                {
                    User objUser = db.User.Single(user => user.Username == rmuser);
                    db.User.DeleteOnSubmit(objUser);
                    db.SubmitChanges();
                    UpdateUsersList();
                }
            }
            catch (System.InvalidOperationException err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string changinguser = usersGrid.CurrentCell.Value.ToString();
            DialogResult userDeleteResult = MessageBox.Show("Вы уверены что хотите сменить роль пользователя " + changinguser + "?", "Системное сообщение", MessageBoxButtons.YesNo);

            try
            {
                if (userDeleteResult == DialogResult.Yes)
                {
                    var objUser = (from c in db.User where c.Username == changinguser select c).First();
                    if (objUser.Role == userRole[0])
                        objUser.Role = userRole[1];
                    else
                        objUser.Role = userRole[0];
                    db.SubmitChanges();
                    UpdateUsersList();
                }
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
