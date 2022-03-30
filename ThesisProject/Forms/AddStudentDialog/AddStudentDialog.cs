using System;
using System.Windows.Forms;

namespace ThesisProject.Forms.AddStudentDialog
{
    public partial class AddStudentDialog : Form
    {
        internal string FirstName, LastName, MiddleName, Group;


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addStudentLastBox.Text) && !string.IsNullOrEmpty(addStudentFirstBox.Text) && !string.IsNullOrEmpty(addStudentGroupBox.Text))
            {
                LastName = addStudentLastBox.Text;
                FirstName = addStudentFirstBox.Text;
                MiddleName = addStudentMiddleBox.Text;
                Group = addStudentGroupBox.Text;
            }
            else
                MessageBox.Show("Проверрьте поля");

        }

        public AddStudentDialog()
        {
            InitializeComponent();
        }

        private void AddStudentDialog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ktkCisDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.ktkCisDataSet.Group);

        }


    }
}
