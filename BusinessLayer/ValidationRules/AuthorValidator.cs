using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar unvanlarını boş geçemezsiniz");
            RuleFor(x => x.AuthorName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik yazar adı girişi yapınız");
            RuleFor(x => x.AuthorTitle).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakterlik yazar unvanı girişi yapınız");
        }

    }
}
