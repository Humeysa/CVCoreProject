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
    public class AboutManager : IAboutService
    {
        IAboutRepository _aboutRepository;
        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void TAdd(About t)
        {
            _aboutRepository.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutRepository.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutRepository.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutRepository.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutRepository.Update(t);
        }
    }
}
