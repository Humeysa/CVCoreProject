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
    public class SkillManager : ISkillService
    {
        ISkillRepository _skillRepository;

        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public void TAdd(Skill t)
        {
            _skillRepository.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillRepository.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skillRepository.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillRepository.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skillRepository.Update(t);
        }
    }
}
