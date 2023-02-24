using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface INewsLetterService
	{
        void AddNewsLetter(NewsLetter newsletter);
    }
}

