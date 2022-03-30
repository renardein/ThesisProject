using System;
using System.Windows.Forms;

namespace ThesisProject.Forms.AddGroupDialog
{
    public partial class AddGroupDialog : Form
    {
        internal string GroupName;
        public AddGroupDialog()
        {
            InitializeComponent();
        }


        private void addGroupButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(addGroupTitleBox.Text))
                GroupName = addGroupTitleBox.Text;
            if (string.IsNullOrEmpty(addGroupTitleBox.Text))
            {
                MessageBox.Show("Проверьте заполненность полей");
                DialogResult = DialogResult.None;
                return;
            }
        }

        private void AddGroupDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
