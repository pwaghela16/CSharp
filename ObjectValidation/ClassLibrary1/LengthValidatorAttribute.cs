using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectValidationLib
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LengthValidatorAttribute : ValidationAttribute
    {
        public LengthValidatorAttribute()
        {
            ValidationName = "Length Validation";
        }
        public int MaxLength { get; set; }

        public override bool Validate(object data)
        {
            
            string value = data.ToString();
            if (value.Length > MaxLength) return true;
            return false;
        }
    }
}
