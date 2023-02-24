using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T TGetByID(int id);
    }
}

