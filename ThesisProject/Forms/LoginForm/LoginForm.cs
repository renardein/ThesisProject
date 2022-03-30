namespace ThesisProject
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using ThesisProject.Modules.TempData;
    using ThesisProject.Modules.Crypto;
    using ThesisProject.Modules.DatabaseAdapter;
    using ThesisProject.Modules.OpenForm;

    public partial class LoginForm : Form
    {
        internal DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

        internal int wrongLoginAttemptsConunt;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            authRoleBox.SelectedIndex = 0;

        }

        private void exitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (wrongLoginAttemptsConunt < 3)
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
                        string roleFromDb = getRoleFromDb.First().ToString();
                        int selectedRole = authRoleBox.SelectedIndex;
                        TempData.CurrentUser = authLoginBox.Text;
                        switch (roleFromDb)
                        {
                            case "admin":
                                {
                                    switch (selectedRole)
                                    {
                                        case 0:
                                            {
                                                OpenForm.AdminForm();
                                                this.Hide();
                                                break;
                                            }
                                        case 1:
                                            {
                                                OpenForm.UserForm();
                                                this.Hide();
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case "user":
                                {
                                    switch (selectedRole)
                                    {
                                        case 0:
                                            {
                                                MessageBox.Show("Нет доступа в данную область");
                                                break;
                                            }
                                        case 1:
                                            {
                                                OpenForm.UserForm();
                                                this.Hide();
                                                break;
                                            }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Пользователя не существует");
                        wrongLoginAttemptsConunt++;
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Проверьте заполненность полей");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Количество недачных попыток: " + wrongLoginAttemptsConunt + ". Выход.");
                Application.Exit();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Обработка нажатия Enter для подтверждения формы
            if (keyData == (Keys.Enter))
            {
                authButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            authLoginBox.Text = default;
            authPassBox.Text = default;
            authRoleBox.SelectedIndex = default;
        }
    }
}
