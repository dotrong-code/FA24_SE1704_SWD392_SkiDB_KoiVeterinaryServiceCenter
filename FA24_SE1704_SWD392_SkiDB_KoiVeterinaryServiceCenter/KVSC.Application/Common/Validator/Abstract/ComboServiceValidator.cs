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
    public class ComboServiceValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public ComboServiceValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void AddComboServiceNameRules(Expression<Func<T, string>> comboServiceNameExpression)
        {
            RuleFor(comboServiceNameExpression)
                .NotEmpty().WithState(_ => (ComboServiceErrorMessage.FieldIsEmpty("ComboService name")));
        }

        protected void AddDiscountPercentageRules(Expression<Func<T, decimal>> discountPercentageExpression)
        {
            RuleFor(discountPercentageExpression)
                .InclusiveBetween(0, 100).WithState(_ => (ComboServiceErrorMessage.InvalidFieldValue("DiscountPercentage")));
        }

        protected void AddServiceItemsRules(Expression<Func<T, IEnumerable<Guid>>> serviceItemsExpression)
        {
            RuleFor(serviceItemsExpression)
                .NotEmpty().WithState(_ => (ComboServiceErrorMessage.FieldIsEmpty("ServiceIds")));
        }
    }
}
