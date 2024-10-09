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
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;
        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
        public ViewMaterial GetMaterial(int id)
        {
            return _materialRepository.GetMaterial(id);
        }
    }
}
