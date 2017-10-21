using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Models
{
    public class User
    {

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = ValidateNewValue(value, "The User Name cannot be empty.");
        }

        public PropertyValue ValidateNewValue<PropertyValue>(PropertyValue value, string message)
        {
            if (Equals(value, default(PropertyValue)))
                throw new InvalidDataException(message);
            return value;
        }
    }

   

}
