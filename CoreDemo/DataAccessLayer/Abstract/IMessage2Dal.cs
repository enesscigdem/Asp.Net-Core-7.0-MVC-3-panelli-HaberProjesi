using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IMessage2Dal : IGenericDal<Message2>
    {
        List<Message2> GetListWithMessageByWriter(int id);
        List<Message2> GetSendBoxListWithMessageByWriter(int id);
    }
}

