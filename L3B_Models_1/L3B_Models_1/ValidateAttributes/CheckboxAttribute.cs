using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L3B_Models_1.ValidateAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckboxAttribute : ValidationAttribute
    {
        bool validation;

        public CheckboxAttribute(bool validation)
        {
            this.validation = validation;
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format("You must accept the terms and conditions.");
        }

        public override bool IsValid(object value)
        {
            return validation.ToString() == value.ToString();
        }
    }
}
