using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ValidatorApp
{
    class PatientInfo
    {
        public PatientInfo()
        {

        }
        [ObjectValidationLib.RequiredValidator(Error ="MRN requires value")]
        public string MRN { get; } = Guid.NewGuid().ToString();

        [ObjectValidationLib.RequiredValidator(Error = "Name requires value")]
        [ObjectValidationLib.LengthValidator(MaxLength = 15,Error = "Length of the name exceeds the limit of 15 characters")]
        public string Name { get; set; }

        [ObjectValidationLib.RangeValidatorAttribute(1,100, Error = "Age Value Must be with in range 1-100")]
        public int Age { get; set; }
    }
}
