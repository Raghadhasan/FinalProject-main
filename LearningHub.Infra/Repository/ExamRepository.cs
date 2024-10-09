using Dapper;
using LearningHub.Core.Common;
using LearningHub.Core.Data;
using LearningHub.Core.DTO;
using LearningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Infra.Repository
{
    public class ExamRepository : IExamRepository
    {
        private readonly IDbContext _dbContext;
        public ExamRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Examsection> CreateExam(Examsection examsection)
        {
            var p = new DynamicParameters();
            p.Add("TRAINER_COURSE", examsection.Trainercourse, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EXAM_LINK", examsection.ExamLink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EXAM_MARK", examsection.Exammark, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("EXAM_DURATION", examsection.Examduration, dbType: DbType.Date, direction: ParameterDirection.Input);

            IEnumerable<Examsection> result = _dbContext.Connection.Query<Examsection>("EXAM_PACKAGE.CREATE_EXAM", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Examsection> GetExamByCourseId(int id)
        {
            var p = new DynamicParameters();
            p.Add("Course_id", id, DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Examsection>("EXAM_PACKAGE.Get_Exam_By_course_Id", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
