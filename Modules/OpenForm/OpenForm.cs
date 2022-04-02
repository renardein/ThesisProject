
using System.Windows.Forms;

namespace ThesisProject.Modules.OpenForm
{
    internal class OpenForm
    {
        public static void AdminForm()
        {
            Forms.AdminForm.AdminForm af = new Forms.AdminForm.AdminForm();
            af.Show();
        }
        public static void UserForm()
        {
            Forms.UserForm.UserForm uf = new Forms.UserForm.UserForm();
            uf.Show();
        }
        public static void KarpikEgg()
        {
            Forms.KarpikEggForm.Main eg = new Forms.KarpikEggForm.Main();
            eg.Show();
        }
        public static object AddGroupDialog()
        {
            Forms.AddGroupDialog.AddGroupDialog agd = new Forms.AddGroupDialog.AddGroupDialog();
            DialogResult res = agd.ShowDialog();
            object rs = res;
            return rs;
        }
        public static void AddStudeintDialog()
        {
            Forms.KarpikEggForm.Main eg = new Forms.KarpikEggForm.Main();
            eg.Show();
        }
    }
}
