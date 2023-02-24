using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        //Control + I  = Ctrl+K+D
        [Key]
        public int CommentID { get; set; }
        public string CommentUsername { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogScore { get; set; }
        public bool CommentStatus { get; set; }
        //ilişki kısmı
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

    }
}

