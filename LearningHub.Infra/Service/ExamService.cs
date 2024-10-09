using LearningHub.Core.Data;
using LearningHub.Core.Repository;
using LearningHub.Core.Services;
using LearningHub.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Infra.Service
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        public List<Examsection> CreateExam(Examsection examsection) { 
            return _examRepository.CreateExam(examsection);
        }
        public List<Examsection> GetExamByCourseId(int id) {
            return _examRepository.GetExamByCourseId(id);
        }
    }
}
