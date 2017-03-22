using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L3A_Models_2.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EmailEndingStringValidation : ValidationAttribute
    {
        string[] hardcodedString;

        public EmailEndingStringValidation(string[] hardcodedString)
        {
            this.hardcodedString = hardcodedString;
        }

        public override bool IsValid(object value)
        {
            var endingIsValid = false;

            if (value != null)
            {
                foreach (string cond in this.hardcodedString)
                {
                    if ((value.ToString()).EndsWith(cond))
                        endingIsValid = true;
                }
            }

            return endingIsValid;
        }
    }
}
