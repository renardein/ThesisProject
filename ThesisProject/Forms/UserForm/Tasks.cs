using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm
{
    internal class Tasks
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

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
        internal int getGroupId(string groupTitle)
        {
            var getGroupIdFromDb = from c in db.Group
                                   where c.Title == groupTitle
                                   select c.GroupId;
            return getGroupIdFromDb.First();

        }
        internal bool isStudentExists(string FirstName, string LastName, string EnteredGroup)
        {
            int gid = getGroupId(EnteredGroup);
            var getGroupFromDb = from st in db.Student
                                 where (st.FirstName == FirstName) && (st.LastName == LastName) && (st.GroupId == gid)
                                 select st;
            if (getGroupFromDb.Count() >= 1)
                return true;
            else
                return false;
        }

        internal void addStudent(string FirstName, string LastName, string MiddleName, string EnteredGroup)
        {
            var addStudent = new Student
            {
                FirstName = FirstName,
                MiddleName = LastName,
                LastName = MiddleName,
                GroupId = getGroupId(EnteredGroup)
            };
            db.Student.InsertOnSubmit(addStudent);
            db.SubmitChanges();
        }
        internal void addGroup(string EnteredGroup)
        {

            var addGroup = new Group
            {
                Title = EnteredGroup,
            };
            db.Group.InsertOnSubmit(addGroup);
            db.SubmitChanges();

        }

        internal void deleteGroup(string gr)
        {
            Group objgroup = db.Group.Single(group => group.Title == gr);
            db.Group.DeleteOnSubmit(objgroup);
            db.SubmitChanges();
        }
    }
}
