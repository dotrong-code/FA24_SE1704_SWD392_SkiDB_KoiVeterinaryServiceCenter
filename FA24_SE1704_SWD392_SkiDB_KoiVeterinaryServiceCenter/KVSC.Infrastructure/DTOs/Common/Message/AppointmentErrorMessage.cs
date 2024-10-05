using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class AppointmentErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
          => Error.Validation("ComboService.Empty", $"The '{nameField}' field is required.");

        public static Error InvalidFieldValue(string fieldName)
            => Error.Validation("ComboService.InvalidValue", $"The '{fieldName}' field has an invalid value.");

    }
}
