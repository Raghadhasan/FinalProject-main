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
    public class MaterialRepository : IMaterialRepository
    {
        private readonly IDbContext _dbContext;
        public MaterialRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ViewMaterial GetMaterial(int id)
        {
            var p = new DynamicParameters();
            p.Add("m_section", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<ViewMaterial>("Material_Package.ViewMaterial", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result;
        }
    }
}
