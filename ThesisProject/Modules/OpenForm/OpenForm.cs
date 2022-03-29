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
            Forms.KarpikEggForm.KarpikEggForm egg = new Forms.KarpikEggForm.KarpikEggForm();
            egg.Show();
        }
    }
}
