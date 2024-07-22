using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.CourseCategoryValidation
{
    public class CreateCoursesValidation : AbstractValidator<Courses>
    {
        public CreateCoursesValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Açıklama En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Açıklama En Fazla 1000 Karakter Olmalıdır");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0'dan Büyük Olmalıdır");
            RuleFor(x => x.Price).LessThan(10000).WithMessage("Fiyat 10000'dan Küçük Olmalıdır");
            RuleFor(x => x.Price).ScalePrecision(2, 5).WithMessage("Fiyat 2 Basamaklı ve 5 Haneli Olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url Boş Geçilemez");
        }
    }
}