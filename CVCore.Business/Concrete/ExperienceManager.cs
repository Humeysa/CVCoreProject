using CVCore.Business.Abstract;
using CVCore.DataAccsess.Abstract;
using CVCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVCore.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceRepository _experienceRepository;
        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public void TAdd(Experience t)
        {
            _experienceRepository.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceRepository.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _experienceRepository.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceRepository.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experienceRepository.Update(t);
        }
    }
}
