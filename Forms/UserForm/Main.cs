using System;
using System.Linq;
using System.Windows.Forms;
using ThesisProject.Modules.TempData;
namespace ThesisProject.Forms.UserForm
{
    public partial class UserForm : Form
    {
        internal Main act = new Main();
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, System.EventArgs e)
        {

            currentUserStrip.Text = TempData.CurrentUser;
            studentFileOpenDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            UpdateGroupsList();
            UpdateStudentsList();

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }


        private void importGroupsButton_Click(object sender, System.EventArgs e)
        {
            if (studentFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] groupByLines = System.IO.File.ReadAllLines(studentFileOpenDialog.FileName);

            foreach (string s in groupByLines)
            {
                act.addGroup(s);
                UpdateGroupsList();
            }

        }



        private void addGroupDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddGroupDialog.AddGroupDialog agd = new AddGroupDialog.AddGroupDialog();
            agd.Owner = this;
            DialogResult res = agd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!act.isGroupExists(agd.GroupName))
                {
                    act.addGroup(agd.GroupName);
                }
            }
            UpdateGroupsList();
        }

        private void deleteGroupButton_Click(object sender, System.EventArgs e)
        {
            string rmGroup = groupGrid.CurrentCell.Value.ToString();
            DialogResult groupDeleteResult = MessageBox.Show("Вы уверены что хотите удалить группу " + rmGroup + "?", "Системное сообщение", MessageBoxButtons.YesNo);

            try
            {
                if (groupDeleteResult == DialogResult.Yes)
                {
                    act.deleteGroup(rmGroup);
                    UpdateGroupsList();
                }
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message);
            }
        }



        private void addStudentDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddStudentDialog.AddStudentDialog asd = new AddStudentDialog.AddStudentDialog();
            asd.Owner = this;
            DialogResult res = asd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!act.isStudentExists(asd.FirstName, asd.LastName, asd.Group))
                {
                    act.addStudent(asd.FirstName, asd.LastName, asd.MiddleName, asd.Group);
                }
                else
                    MessageBox.Show("Запись существует");

            }
            UpdateStudentsList();
        }


        private void UpdateGroupsList()
        {
            TempData.GroupsList = act.GetGroups();
            groupGrid.DataSource = act.GetGroups();

        }
        private void UpdateStudentsList()
        {
            studentGrid.DataSource = act.GetStudents();
        }


        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void importStudentsButton_Click(object sender, EventArgs e)
        {
            if (studentFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] groupByLines = System.IO.File.ReadAllLines(studentFileOpenDialog.FileName);

            foreach (string s in groupByLines)
            {
                string[] words = s.Split(',');
                string group = words[1];
                string[] splitname = words[0].Split(' ');
                string getMiddleName;
                if (splitname.Count() == 2)
                    getMiddleName = null;
                else
                    getMiddleName = splitname[2];
                if (!act.isGroupExists(group))
                {
                    act.addGroup(group);
                    act.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }
                else
                {
                    act.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }
                UpdateGroupsList();
                UpdateStudentsList();
            }
        }

        private void deleteAllGroupsAndStudents_Click(object sender, EventArgs e)
        {
            act.deleteAllStudentsAndGroups();
        }

        private void groupGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            studentGrid.DataSource = act.SortStudentsByGroup(groupGrid.CurrentCell.Value.ToString()); ;
        }


    }
}
