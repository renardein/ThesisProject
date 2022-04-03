using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm.Actions
{
    internal class ProModuleAct
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

        /// <summary>
        /// Поулчает список ПМ из базы
        /// </summary>
        internal object GetProModules()
        {
            return from p in db.ProModule select new { Модуль = p.Title };
        }

        /// <summary>
        /// Проверяет наличие ПМ в базе
        /// </summary>
        /// <param name="pmTitle">Наименование ПМ</param>
        internal bool isModuleExists(string pmTitle)
        {
            var getPmFromDb = from pm in db.ProModule where pm.Title == pmTitle select pm;
            if (getPmFromDb.Count() >= 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Добавляет ПМ в базу
        /// </summary>
        /// <param name="pmTitle">Наименование ПМ</param>
        internal void addProModule(string pmTitle)
        {
            var addPm = new ProModule
            {
                Title = pmTitle
            };
            db.ProModule.InsertOnSubmit(addPm);
            db.SubmitChanges();
        }

        /// <summary>
        /// Поулчает ID ПМ из базы по наименованию
        /// </summary>
        /// <param name="pmTitle">Наименование ПМ</param>
        internal int getProModuleId(string pmTitle)
        {
            var getModuleIdFromDb = from c in db.ProModule
                                    where c.Title == pmTitle
                                    select c.ModuleId;
            return getModuleIdFromDb.First();

        }

        /// <summary>
        /// Удаляет ПМ из базы
        /// </summary>
        /// <param name="pmTitle">Наименование ПМ</param>
        internal void deleteProModule(string pmTitle)
        {
            ProModule objPm = db.ProModule.Single(pm => pm.Title == pmTitle);
            db.ProModule.DeleteOnSubmit(objPm);
            db.SubmitChanges();
        }
    }
}
