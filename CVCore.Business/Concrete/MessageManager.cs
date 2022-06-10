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
    public class MessageManager : IMessageService
    {
        IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void TAdd(Message t)
        {
            _messageRepository.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageRepository.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageRepository.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageRepository.GetList();
        }

        public void TUpdate(Message t)
        {
            _messageRepository.Update(t);
        }
    }
}
