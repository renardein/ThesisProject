using System.Windows.Forms;
using ThesisProject.Modules.DatabaseAdapter;
using System.Data;
using System.Linq;

namespace ThesisProject.Forms.UserForm
{
    public partial class UserForm : Form
    {
        internal DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

        public UserForm()
        {
            InitializeComponent();

        }

        private void UserForm_Load(object sender, System.EventArgs e)
        {
            currentUserStrip.Text = Program.FormDataExchange.CurrentUser;
            studentFileOpenDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            UpdateGroupsList();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void importGroupsButton_Click(object sender, System.EventArgs e)
        {
            if (studentFileOpenDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = studentFileOpenDialog.FileName;
            // читаем файл в строку
            string[] groupByLines = System.IO.File.ReadAllLines(filename);
            
            foreach (string s in groupByLines)
            {
                var addGroup = new Group
                {
                    Title = s
                };
                db.Group.InsertOnSubmit(addGroup);
                db.SubmitChanges();
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
        private void UpdateGroupsList()
        {
            groupGrid.DataSource = from p in db.Group select new { Гурппа = p.Title };
        }

        private void groupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addGroupDialogOpen_Click(object sender, System.EventArgs e)
        {
            AddGroupDialog.AddGroupDialog agd = new AddGroupDialog.AddGroupDialog();
            agd.Owner = this;
            DialogResult res = agd.ShowDialog();
            if (res == DialogResult.OK)
            {
                var addGroup = new Group
                {
                    Title = Program.FormDataExchange.NewGroupString
                };

                db.Group.InsertOnSubmit(addGroup);
                db.SubmitChanges();
                UpdateGroupsList();
            }
        }
    }
}
