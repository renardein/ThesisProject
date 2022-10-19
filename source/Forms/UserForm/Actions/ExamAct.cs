using System;
using System.Collections.Generic;
using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm.Actions
{

    internal class ExamAct
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        GroupAct ga = new Actions.GroupAct();
        ProModuleAct pa = new ProModuleAct();

        internal object UpdateExams()
        {
            return from p in db.ExamView
                   select p;
        }
        internal void addExam(string Group, string Module, string datetime, string ExaminerList)
        {
            var addExam = new Exam
            {
                GroupId = ga.getGroupId(Group),
                ModuleId = pa.getProModuleId(Module),
                Date = Convert.ToDateTime(datetime),
                Examiner = ExaminerList
            };
            db.Exam.InsertOnSubmit(addExam);
            db.SubmitChanges();
        }
        internal int getExamId(string datetime, int Module, int groupId)
        {
            var getModuleIdFromDb = from c in db.Exam
                                    where (c.Date == Convert.ToDateTime(datetime)) && (c.ModuleId == Module) && (c.GroupId == groupId)
                                    select c.ExamId;
            return getModuleIdFromDb.First();
        }
        internal void deleteExam(string Group, string Date)
        {

        }

        internal object getExamTitle(string selgroup)
        {
            return from e in db.ExamView where e.Группа == selgroup select new { Экзамен = e.Модуль + e.Дата };

        }

        internal (object table, string groupname, IEnumerable<int> examId) getExam(string selgroup)
        {
            IEnumerable<int> examId = from e in db.Exam where e.GroupId == ga.getGroupId(selgroup) select e.ExamId;
            var table = from e in db.ExamView where e.Группа == selgroup select new { Экзамен = e.Модуль + e.Дата };
            string groupname = selgroup;

            return (table, groupname, examId);

        }
    }
}
