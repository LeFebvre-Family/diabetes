using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Models
{

    public class Food
    {
        private string _name;
        private string _foodname;
        private MeasuredAmount _foodquantity;
        private string _foodcarbs;


        public string Name
        {
            get => _name;
            set => _name = ValidateNewValue(value, "The Food Name cannot be empty.");
        }


        public string Carbohydrates
        {
            get => _foodcarbs;
            set => _foodcarbs = ValidateNewValue(value, "You must have more than zero carbs.");
        }


        public MeasuredAmount Quantity
        {
            get => _foodquantity;
            set => _foodquantity = ValidateNewValue(value, "The quantity of food cannot be null.");
        }



        public DateTime Birthdate { get; set; }

        public int Age => (DateTime.UtcNow.Year - Birthdate.Year);

        public PropertyValue ValidateNewValue<PropertyValue>(PropertyValue value, string message)
        {
            if (Equals(value, default(PropertyValue)))
                throw new InvalidDataException(message);
            return value;
        }

        public MeasuredAmount ValidateNewValue(MeasuredAmount value, string message)
        {
            if (Equals(value, default(MeasuredAmount)))
                throw new InvalidDataException(message);

            if (string.IsNullOrEmpty(value.Unit))
                throw new InvalidDataException(message);
            return value;
        }

    }
}