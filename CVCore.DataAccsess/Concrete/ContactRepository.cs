using CVCore.DataAccsess.Abstract;
using CVCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVCore.DataAccsess.Concrete
{
    public class ContactRepository:GenericRepository<Contact>, IContactRepository
    {
    }
}
