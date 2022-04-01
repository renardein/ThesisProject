using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ThesisProject.Modules.DatabaseAdapter;
using ThesisProject.Modules.TempData;
namespace ThesisProject.Forms.UserForm
{
    public partial class UserForm : Form
    {
        internal DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        internal Tasks tsk = new Tasks();


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
            string filename = studentFileOpenDialog.FileName;
            string[] groupByLines = System.IO.File.ReadAllLines(filename);

            foreach (string s in groupByLines)
            {
                tsk.addGroup(s);
                UpdateGroupsList();
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var getTable = from p in db.Group
                           select p;
            foreach (var g in getTable)
            {
                db.Group.DeleteOnSubmit(g);
            }
            db.SubmitChanges();
            UpdateGroupsList();

        }


        private void addGroupDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddGroupDialog.AddGroupDialog agd = new AddGroupDialog.AddGroupDialog();
            agd.Owner = this;
            DialogResult res = agd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!tsk.isGroupExists(agd.GroupName))
                {
                    tsk.addGroup(agd.GroupName);
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
                    tsk.deleteGroup(rmGroup);
                    UpdateGroupsList();
                }
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboFilterByGroup.SelectedIndex == 0)
                UpdateStudentsList();
            else
                studentGrid.DataSource = from p in db.StudentGroup where p.Title == comboFilterByGroup.Text select new { Студент = p.FirstName + p.MiddleName + p.LastName, Гурппа = p.Title };
        }
        private void addStudentDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddStudentDialog.AddStudentDialog asd = new AddStudentDialog.AddStudentDialog();
            asd.Owner = this;
            DialogResult res = asd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!tsk.isStudentExists(asd.FirstName, asd.LastName, asd.Group))
                {
                    tsk.addStudent(asd.FirstName, asd.LastName, asd.MiddleName, asd.Group);
                }
                else
                    MessageBox.Show("Запись существует");

            }
            UpdateStudentsList();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var getTable = from p in db.Student
                           select p;
            foreach (var g in getTable)
            {
                db.Student.DeleteOnSubmit(g);
            }
            db.SubmitChanges();
            UpdateStudentsList();

        }

        private void UpdateGroupsList()
        {
            comboFilterByGroup.Items.Clear();
            groupGrid.DataSource = from p in db.Group select new { Группа = p.Title };
            comboFilterByGroup.Items.Add("Без фильтра");
            var getGroupsList = (from p in db.Group select p.Title);
            TempData.GroupsList = getGroupsList;
            foreach (var item in getGroupsList)
            {
                comboFilterByGroup.Items.Add(item.ToString());
            }

        }
        private void UpdateStudentsList()
        {
            studentGrid.DataSource = from p in db.StudentGroup select new { Студент = p.FirstName + p.MiddleName + p.LastName, Группа = p.Title };
        }


        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void importStudentsButton_Click(object sender, EventArgs e)
        {
            if (studentFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = studentFileOpenDialog.FileName;
            // читаем файл в строку
            string[] groupByLines = System.IO.File.ReadAllLines(filename);

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
                if (!tsk.isGroupExists(group))
                {
                    tsk.addGroup(group);
                    tsk.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }
                else
                {
                    tsk.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }


                UpdateGroupsList();
                UpdateStudentsList();

            }
        }
    }
}
