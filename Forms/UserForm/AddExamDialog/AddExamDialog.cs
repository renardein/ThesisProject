using System;
using System.Windows.Forms;

namespace ThesisProject.Forms.UserForm.AddExamDialog
{
    public partial class AddExamDialog : Form
    {
        public AddExamDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddExamDialog_Load(object sender, EventArgs e)
        {
            addExamGroupBox.DataSource = Modules.TempData.TempData.GroupsList;
            addExamGroupBox.DisplayMember = "Группа";
        }
    }
}
