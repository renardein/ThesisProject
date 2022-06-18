using ThesisProject.Modules.DatabaseAdapter;
using System.Linq;
using System;

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
                GroupId =  ga.getGroupId(Group),
                ModuleId = pa.getProModuleId(Module),
                Date = Convert.ToDateTime(datetime),
                Examiner = ExaminerList
            };
            db.Exam.InsertOnSubmit(addExam);
            db.SubmitChanges();
        }
    }
}
