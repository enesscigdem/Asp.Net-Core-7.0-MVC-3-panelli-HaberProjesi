using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}

