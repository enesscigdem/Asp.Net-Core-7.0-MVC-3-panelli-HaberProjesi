using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IWriterService : IGenericService<Writer>
	{
		List<Writer> GetWriterByID(int id);
    }
}

