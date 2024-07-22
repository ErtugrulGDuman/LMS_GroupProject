using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete._2_AdminArea.General;
using FluentValidation;

namespace BusinessLayer.ValidationRules.CourseCategoryValidation
{
    public class CreateCourseCategoryValidation : AbstractValidator<CourseCategory>
    {
        public CreateCourseCategoryValidation()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
            RuleFor(x=>x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En Az 3 Karakter Olmalıdır");
            RuleFor(x=>x.CategoryName).MaximumLength(50).WithMessage("Kategori Adı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Resim Url Boş Geçilemez");
            RuleFor(x=>x.IconUrl).NotEmpty().WithMessage("Icon Url Boş Geçilemez");
        }
    }
}