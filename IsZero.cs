using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб1.Validation
{
    public class IsZero : Specification<int>
    {
        public override void Validate(int value)
        {
            if (value != 0)
            {
                throw new ValidationException(string.Format("Value {0} must be zero.", value));
            }
        }
    }
}
