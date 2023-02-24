using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Category
	{
        [Key]
        // Erişim belirleyici türü - Değişken türü - İsim - {get-set}
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        //ilişki kısmı
        public List<Blog> Blogs { get; set; }
    }
}

