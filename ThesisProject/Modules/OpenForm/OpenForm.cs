
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
            Forms.KarpikEggForm.KarpikEggForm eg = new Forms.KarpikEggForm.KarpikEggForm();
            eg.Show();
        }
        public static void AddGroupDialog()
        {
            Forms.AddGroupDialog.AddGroupDialog agd = new Forms.AddGroupDialog.AddGroupDialog();
            DialogResult res = agd.ShowDialog();
            object rs = res;
            return;
        }
        public static void AddStudeintDialog()
        {
            Forms.KarpikEggForm.KarpikEggForm eg = new Forms.KarpikEggForm.KarpikEggForm();
            eg.Show();
        }
    }
}
