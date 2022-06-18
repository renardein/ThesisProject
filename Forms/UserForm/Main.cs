﻿using System;
using System.Linq;
using System.Windows.Forms;
using ThesisProject.Forms.UserForm.Actions;
using ThesisProject.Modules.TempData;

namespace ThesisProject.Forms.UserForm
{
    public partial class UserForm : Form
    {
        internal GroupAct ga = new GroupAct();
        internal StudentAct sa = new StudentAct();
        internal ProModuleAct pa = new ProModuleAct();
        internal ExamAct ea = new ExamAct();
        internal ReportingAct ReportingAct = new ReportingAct();
        internal MarkingAct ma = new MarkingAct();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, System.EventArgs e)
        {
            this.examGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            currentUserStrip.Text = TempData.CurrentUser;
            txtFileOpenDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            UpdateGroupsList();
            UpdateStudentsList();
            UpdatePmList();
            UpdateExamList();

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }


        private void importGroupsButton_Click(object sender, System.EventArgs e)
        {
            if (txtFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] groupByLines = System.IO.File.ReadAllLines(txtFileOpenDialog.FileName);

            foreach (string s in groupByLines)
            {
                if (!ga.isGroupExists(s))
                    ga.addGroup(s);
                else
                    return;

            }
            UpdateGroupsList();
        }



        private void addGroupDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddGroupDialog.AddGroupDialog agd = new AddGroupDialog.AddGroupDialog();
            agd.Owner = this;
            DialogResult res = agd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!ga.isGroupExists(agd.GroupName))
                {
                    ga.addGroup(agd.GroupName);
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
                    ga.deleteGroup(rmGroup);
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

                if (!sa.isStudentExists(asd.FirstName, asd.LastName, asd.Group))
                {
                    sa.addStudent(asd.FirstName, asd.LastName, asd.MiddleName, asd.Group);
                }
                else
                    MessageBox.Show("Запись существует");

            }
            UpdateStudentsList();
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void importStudentsButton_Click(object sender, EventArgs e)
        {
            if (txtFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] groupByLines = System.IO.File.ReadAllLines(txtFileOpenDialog.FileName);

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
                if (!ga.isGroupExists(group))
                {
                    ga.addGroup(group);
                    sa.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }
                else
                {
                    sa.addStudent(splitname[1], getMiddleName, splitname[0], group);
                }
                UpdateGroupsList();
                UpdateStudentsList();
            }
        }

        private void groupGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string gr = this.studentGrid.CurrentRow.Cells[1].Value.ToString();

            studentGrid.DataSource = sa.SortStudentsByGroup(gr);
        }


        private void addProModuleDialogOpen_Click(object sender, EventArgs e)
        {
            AddProModuleDialog.AddProModuleDialog apmd = new AddProModuleDialog.AddProModuleDialog();
            apmd.Owner = this;
            DialogResult res = apmd.ShowDialog();
            if (res == DialogResult.OK)
            {

                if (!pa.isModuleExists(apmd.PmName))
                {
                    pa.addProModule(apmd.PmName);
                }
            }
            UpdatePmList();
        }

        private void deletePmButton_Click(object sender, EventArgs e)
        {
            string rmPm = pmGrid.CurrentCell.Value.ToString();
            DialogResult pmDeleteResult = MessageBox.Show("Вы уверены что хотите удалить модуль " + rmPm + "?", "Системное сообщение", MessageBoxButtons.YesNo);

            try
            {
                if (pmDeleteResult == DialogResult.Yes)
                {
                    pa.deleteProModule(rmPm);
                    UpdatePmList();
                }
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void importPmButton_Click(object sender, EventArgs e)
        {
            if (txtFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string[] pmByLines = System.IO.File.ReadAllLines(txtFileOpenDialog.FileName);

            foreach (string s in pmByLines)
            {
                if (!pa.isModuleExists(s))
                    pa.addProModule(s);
                else
                    return;
            };
            UpdatePmList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddExamDialog.AddExamDialog aed = new AddExamDialog.AddExamDialog();
            aed.Owner = this;
            DialogResult res = aed.ShowDialog();
            if (res == DialogResult.OK)
            {
                ea.addExam(aed.Group, aed.Module, aed.DateTime, aed.Examiner);

            }
            UpdateExamList();
        }


        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            string name = this.studentGrid.CurrentRow.Cells[0].Value.ToString();
            string group = this.studentGrid.CurrentRow.Cells[1].Value.ToString();
            DialogResult studentDeleteResult = MessageBox.Show("Вы уверены что хотите удалить cтудента " + name + " из группы " + group + "?", "Системное сообщение", MessageBoxButtons.YesNo);

            try
            {
                if (studentDeleteResult == DialogResult.Yes)
                {

                    sa.deleteStudent(name, group);
                }
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message);
            }
            UpdateStudentsList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/renardein/ThesisProject");
        }

        private void UpdateGroupsList()
        {
            TempData.GroupsList = ga.GetGroups();
            groupGrid.DataSource = ga.GetGroups();

        }
        private void UpdateStudentsList()
        {
            studentGrid.DataSource = sa.GetStudents();
        }

        private void UpdatePmList()
        {
            TempData.ProModulesList = pa.GetProModules();
            pmGrid.DataSource = pa.GetProModules();
        }
        private void UpdateExamList()
        {
           examGrid.DataSource = ea.UpdateExams();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
