using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() //RuleFor() metodu ile mesaj gönderebilriiz. //validation'ı UI katmanında kullanmak için oraya da paketi indirmeliyiz..
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını Boş Geçemezsiniz...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");
            RuleFor(X => X.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Karakter sınırını geçtiniz maksimum 1500 karakter.");
        }
    }
}
