using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.AdminForm
{
    internal class Tasks
    {
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
    }
}
