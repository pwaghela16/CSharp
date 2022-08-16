using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectValidationLib

{
    
    public class RangeValidatorAttribute : ValidationAttribute 
    {
        public RangeValidatorAttribute(int minRange, int maxRange)
        {
            this.MaxRange = maxRange;
            this.MinRange = minRange;
            ValidationName = "Range Validation";
        }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        
        public override bool Validate(object data)
        {
            int value = Convert.ToInt32(data);
            if (value < MaxRange && value > MinRange) return false;
            return true;
        }
    }
}
