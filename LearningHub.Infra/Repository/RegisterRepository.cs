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
    public class RegisterRepository : IRegisterRepository
    {
        private readonly IDbContext _dbContext;
        public RegisterRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserRegister> Auth(UserRegister user)
        {
            var p = new DynamicParameters();
            p.Add("u_name", user.u_name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("u_image", user.u_image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("u_email", user.u_email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("l_name", user.l_name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("l_password", user.l_password, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<UserRegister> result = _dbContext.Connection.Query<UserRegister>("UserLogin_Package.CreateUser", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

    }
}
