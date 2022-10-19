using System;
using System.Windows.Forms;
using ThesisProject.Forms.UserForm.Actions;
namespace ThesisProject.Forms.UserForm.AddExamDialog
{
    public partial class AddExamDialog : Form
    {
        GroupAct ga = new GroupAct();
        ProModuleAct pa = new ProModuleAct();
        internal string DateTime, Examiner, Group, Module;
        string[] criteriaByLines;
        internal string[] Criteria;
        public AddExamDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Group = addExamGroupBox.Text;
            Module = addExamProModuleBox.Text;
            DateTime = examDatetime.Text;
            Examiner = examinerBox.Text;
            Criteria = criteriaByLines;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddExamDialog_Load(object sender, EventArgs e)
        {
            addExamProModuleBox.DataSource = Modules.TempData.TempData.ProModulesList;
            addExamGroupBox.DataSource = Modules.TempData.TempData.GroupsList;
            addExamGroupBox.DisplayMember = "Группа";
            addExamProModuleBox.DisplayMember = "Модуль";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openCriteriaFileDialog.Title = "Выберите файл критериев";
            if (openCriteriaFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            criteriaByLines = System.IO.File.ReadAllLines(openCriteriaFileDialog.FileName);
            criteriaFilenameBox.Text = openCriteriaFileDialog.FileName;

        }

        private void examDatetime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
