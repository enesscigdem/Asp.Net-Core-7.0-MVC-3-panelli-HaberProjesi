using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
        void CommentAdd(Comment comment);
        //void BlogDelete(Blog blog);
        //void BlogUpdate(Blog blog);
        List<Comment> GetList(int id);
        //Blog GetByID(int id);
        List<Comment> GetCommentWithBlog();

    }
}

