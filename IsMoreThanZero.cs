using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1.Validation
{
    public class IsMoreThanZero : Specification<int>
    {
        public override void Validate(int value)
        {
            if (value <= 0)
            {
                throw new ValidationException(string.Format("Value {0} must be more than zero.", value));
            }
        }
    }
}