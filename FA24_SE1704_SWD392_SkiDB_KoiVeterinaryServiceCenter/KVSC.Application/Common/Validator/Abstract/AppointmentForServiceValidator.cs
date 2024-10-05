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
    public class AppointmentForServiceValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public AppointmentForServiceValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void MakeAppointmentForServiceRules(Expression<Func<T, Guid>> comboServiceNameExpression, string name)
        {
            RuleFor(comboServiceNameExpression)
                .NotEmpty().WithState(_ => (AppointmentErrorMessage.FieldIsEmpty(name)));
        }
    }
}
