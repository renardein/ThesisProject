using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm.Actions
{
    internal class GroupAct
    {

        internal DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

        /// <summary>
        /// Проверяет наличие группы в базе
        /// </summary>
        /// <param name="groupTitle">Наименование группы</param>
        internal bool isGroupExists(string groupTitle)
        {
            var getGroupFromDb = from c in db.Group
                                 where c.Title == groupTitle
                                 select c;
            if (getGroupFromDb.Count() >= 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Получает ID группы по ее наименованию
        /// </summary>
        /// <param name="groupTitle">Наименование группы</param>
        internal int getGroupId(string groupTitle)
        {
            var getGroupIdFromDb = from c in db.Group
                                   where c.Title == groupTitle
                                   select c.GroupId;
            return getGroupIdFromDb.First();

        }

        /// <summary>
        /// Добавляет группу в базу
        /// </summary>
        /// <param name="EnteredGroup">Наименование группы</param>
        internal void addGroup(string EnteredGroup)
        {

            var addGroup = new Group
            {
                Title = EnteredGroup
            };
            db.Group.InsertOnSubmit(addGroup);
            db.SubmitChanges();

        }
        /// <summary>
        /// Удаляет гуппу из базы
        /// </summary>
        /// <param name="gr">Наименование группы</param>
        internal void deleteGroup(string gr)
        {
            Group objGroup = db.Group.Single(group => group.Title == gr);
            db.Group.DeleteOnSubmit(objGroup);
            db.SubmitChanges();
        }

        /// <summary>
        /// Получает список групп из базы
        /// </summary>
        internal object GetGroups()
        {
            var gr = from p in db.Group select new { Группа = p.Title };
            return gr;
        }
    }
}
