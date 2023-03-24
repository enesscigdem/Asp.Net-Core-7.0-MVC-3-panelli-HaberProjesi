using System;
using System.ComponentModel.DataAnnotations;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CoreDemo.Models
{
	public class UserSignInViewModel
	{
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }
		public string password { get; set; }
	}
}

