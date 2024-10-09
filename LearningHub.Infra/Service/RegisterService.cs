using LearningHub.Core.DTO;
using LearningHub.Core.Repository;
using LearningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Infra.Service
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository _registerRepository;

        public RegisterService(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public List<UserRegister> Auth(UserRegister user)
        {
            return _registerRepository.Auth(user);
        }


    }
}
