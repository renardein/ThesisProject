using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.AdminForm
{
    internal class Tasks
    {
        string[] userRole = new string[] { "admin", "user" };
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        internal bool isUserExists(string username)
        {
            var getUserFromDb = from c in db.User
                                where c.Username == username
                                select c;
            if (getUserFromDb.Count() == 1)
                return true;
            else
                return false;
        }

        internal void addUser(string username, string pwd_hash, int role)
        {
            var newUser = new User
            {
                Username = username,
                Password = pwd_hash,
                Role = userRole[role]
            };
            db.User.InsertOnSubmit(newUser);
            db.SubmitChanges();
        }

        internal void changeUserRole(string username)
        {
            var objUser = (from c in db.User where c.Username == username select c).First();
            if (objUser.Role == userRole[0])
                objUser.Role = userRole[1];
            else
                objUser.Role = userRole[0];
            db.SubmitChanges();
        }

        internal void deleteUser(string usr)
        {
            User objUser = db.User.Single(user => user.Username == usr);
            db.User.DeleteOnSubmit(objUser);
            db.SubmitChanges();
        }

    }
}
