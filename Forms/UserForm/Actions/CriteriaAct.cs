using System.Linq;
using ThesisProject.Modules.DatabaseAdapter;

namespace ThesisProject.Forms.UserForm.Actions
{
    internal class CriteriaAct
    {
        DatabaseAdapterDataContext db = new DatabaseAdapterDataContext();
        ExamAct ea = new ExamAct();

        internal void addCriteria(int examId, string criteriaBody, decimal maxMark, decimal step)
        {

            var addCriteria = new Criteria
            {
                ExamId = examId,
                CriteriaBody = criteriaBody,
                MaxMark = maxMark,
                Step = step
            };
            db.Criteria.InsertOnSubmit(addCriteria);
            db.SubmitChanges();
        }
        internal object getCriteriaByExam(int ExamId)
        {
            var Criterias = from c in db.Criteria where c.ExamId == ExamId select new { Критерий = c.CriteriaBody, Шаг = c.Step, Максимальный_балл = c.MaxMark };
            return Criterias;
        }


    }
}
