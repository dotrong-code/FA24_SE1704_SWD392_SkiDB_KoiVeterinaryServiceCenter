using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Abstract
{
    public class PetServiceCategoryValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public PetServiceCategoryValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void AddCategoryNameRules(Expression<Func<T, string>> categoryNameExpression)
        {
            RuleFor(categoryNameExpression)
                .NotEmpty().WithState(_ => (PetServiceCategoryErrorMessage.FieldIsEmpty("Category name")));
        }

        protected void AddDescriptionRules(Expression<Func<T, string>> descriptionExpression)
        {
            RuleFor(descriptionExpression)
                .NotEmpty().WithState(_ => (PetServiceCategoryErrorMessage.FieldIsEmpty("Description")));
        }

        protected void AddServiceTypeRules(Expression<Func<T, string>> serviceTypeExpression)
        {
            RuleFor(serviceTypeExpression)
                .NotEmpty().WithState(_ => (PetServiceCategoryErrorMessage.FieldIsEmpty("ServiceType")));
        }
            
        protected void AddApplicableToRules(Expression<Func<T, string>> applicableToExpression)
        {
            RuleFor(applicableToExpression)
                .NotEmpty().WithState(_ => (PetServiceCategoryErrorMessage.FieldIsEmpty("ApplicableTo")));
        }
    }
}
