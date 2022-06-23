using System;
using System.Windows.Forms;

namespace ThesisProject.Forms.UserForm.ReportSettingsDialog
{
    public partial class ReportSettingsDialog : Form
    {
        StudentAct sa = new StudentAct();
        public ReportSettingsDialog()
        {
            InitializeComponent();
            reportGroupList.DataSource = Modules.TempData.TempData.GroupsList;
            reportGroupList.DisplayMember = "Группа";
            //  reportStudentList.DisplayMember = "Студент";
        }

        private void ReportSettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void reportStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportStudentList.DisplayMember = "Студент";
            reportStudentList.DataSource = sa.SortStudentsByGroup(reportGroupList.Text);
        }
    }
}
