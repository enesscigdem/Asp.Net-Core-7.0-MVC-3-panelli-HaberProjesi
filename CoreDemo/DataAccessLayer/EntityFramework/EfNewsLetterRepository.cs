using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {
		
	}
}

