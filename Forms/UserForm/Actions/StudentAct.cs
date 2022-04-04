using System.Data;
using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm
{
    internal class StudentAct
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();

        Actions.GroupAct ga = new Actions.GroupAct();

        /// <summary>
        /// Получает список студентов из базы
        /// </summary>
        internal object GetStudents()
        {
            return from p in db.StudentGroup select new { Студент = p.Student, Группа = p.Group };
        }
        /// <summary>
        /// Получает сортированный по группе список студентов из базы
        /// </summary>
        /// <param name="gr">Наименование группы</param>
        internal object SortStudentsByGroup(string gr)
        {
            return (from p in db.StudentGroup where p.Student == gr select new { Студент = p.Student, Группа = p.Group });
        }


        /// <summary>
        /// Проверяет наличие студента в базе
        /// </summary>
        /// <param name="EnteredGroup">Наименование группы</param>
        /// <param name="FirstName">Имя студента</param>
        /// <param name="LastName">Фамилия студента</param>
        internal bool isStudentExists(string FirstName, string LastName, string EnteredGroup)
        {
            int gid = ga.getGroupId(EnteredGroup);
            var getGroupFromDb = from st in db.Student
                                 where (st.FirstName == FirstName) && (st.LastName == LastName) && (st.GroupId == gid)
                                 select st;
            if (getGroupFromDb.Count() >= 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Добавляет студента в базу
        /// </summary>
        /// <param name="EnteredGroup">Наименование группы</param>
        /// <param name="FirstName">Имя студента</param>
        /// <param name="LastName">Фамилия студента</param>
        internal void addStudent(string FirstName, string LastName, string MiddleName, string EnteredGroup)
        {
            var addStudent = new Student
            {
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                GroupId = ga.getGroupId(EnteredGroup)
            };
            db.Student.InsertOnSubmit(addStudent);
            db.SubmitChanges();
        }

        /// <summary>
        /// Удаляет записи из таблиц Groups и Students
        /// </summary>
        internal void deleteAllStudentsAndGroups()
        {
            var getTableStudents = from p in db.Student
                                   select p;
            var getTableGroups = from p in db.Group
                                 select p;
            foreach (var s in getTableStudents)
            {
                db.Student.DeleteOnSubmit(s);
            }
            foreach (var g in getTableGroups)
            {
                db.Group.DeleteOnSubmit(g);
            }
            db.SubmitChanges();
        }

        /// <summary>
        /// Добавляет студента в базу
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="gr">Группа</param>

        internal void deleteStudent(string name, string gr)
        {
            string[] splitname = name.Split(' ');
            var getTableStudents = from s in db.Student
                                   where (s.FirstName == splitname[0]) && (s.MiddleName == splitname[1]) && (s.LastName == splitname[2]) && (s.GroupId == ga.getGroupId(gr))
                                   select s;

            foreach (var s in getTableStudents)
            {
                db.Student.DeleteOnSubmit(s);
            }
            db.SubmitChanges();

        }
    }
}
