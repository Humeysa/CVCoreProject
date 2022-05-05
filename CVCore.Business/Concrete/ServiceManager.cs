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
    public class ServiceManager : IServiceService
    {
        private IServiceRepository _serviceRepository;
        public ServiceManager(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public void TAdd(Service t)
        {
            _serviceRepository.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceRepository.Delete(t);
        }

        public void TUpdate(Service t)
        {
            _serviceRepository.Update(t);
        }

        public Service TGetByID(int id)
        {
            return _serviceRepository.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceRepository.GetList();
        }
    }
}
