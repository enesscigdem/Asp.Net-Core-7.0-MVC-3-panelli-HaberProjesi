using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IMessage2Service : IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
        List<Message2> GetSendBoxListByWriter(int id);
    }
}

