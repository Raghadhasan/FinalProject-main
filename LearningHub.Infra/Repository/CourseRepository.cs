using Dapper;
using LearningHub.Core.Common;
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
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbContext _dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TraineeCourses> GetCourseByTraineeSection(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TraineeCourses> res = _dbContext.Connection.Query<TraineeCourses>("Course_Package.GetCourseByTraineeSection", p, commandType: CommandType.StoredProcedure);
            return res.ToList();
        }


    }
}
