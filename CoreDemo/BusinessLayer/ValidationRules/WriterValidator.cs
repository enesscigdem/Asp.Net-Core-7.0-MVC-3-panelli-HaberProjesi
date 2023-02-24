using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            //ödev kısmı
            RuleFor(x => x.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf içermelidir.");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifre en az bir sayı içermelidir.");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harf içermelidir.");
            //end
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın.");
        }
	}
}

