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
            addExamProModuleBox.DataSource = Modules.TempData.TempData.ProModulesList;
            addExamGroupBox.DataSource = Modules.TempData.TempData.GroupsList;
            addExamProModuleBox.DisplayMember = "Модуль";
            addExamGroupBox.DisplayMember = "Группа";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openCriteriaFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] criteriaByLines = System.IO.File.ReadAllLines(openCriteriaFileDialog.FileName);
            criteriaFilenameBox.Text = openCriteriaFileDialog.FileName;

        }

        private void examDatetime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
