using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm.Actions
{
    internal class ProModuleAct
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        internal object GetProModules()
        {
            return from p in db.ProModule select new { Модуль = p.Title };
        }
        internal bool isModuleExists (string title)
        {
            var getPmFromDb = from pm in db.ProModule where pm.Title == title select pm;
            if (getPmFromDb.Count() >= 1)
                return true;
            else
                return false;
        }

        internal void addProModule(string title)
        {
            var addPm = new ProModule
            {
                Title = title
            };
            db.ProModule.InsertOnSubmit(addPm);
            db.SubmitChanges();
        }
    }
}
