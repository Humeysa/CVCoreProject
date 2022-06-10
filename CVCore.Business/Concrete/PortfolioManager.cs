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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioRepository _portfolioRepository;

        public PortfolioManager(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public void TAdd(Portfolio t)
        {
            _portfolioRepository.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioRepository.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioRepository.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioRepository.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioRepository.Update(t);
        }
    }
}
