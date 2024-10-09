using Dapper;
using LearningHub.Core.Common;
using LearningHub.Core.Data;
using LearningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Infra.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbContext _dbContext;
        public LoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Userlogin Authh(Userlogin login)
        {
            var p = new DynamicParameters();
            p.Add("u_name", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("u_pass", login.Passwordd, dbType: DbType.String, direction: ParameterDirection.Input);

            var res = _dbContext.Connection.Query<Userlogin>("UserLogin_Package.login", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return res;

        }
    }
}
