using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Annotations
{
    public class ValidAuthorAttribute : ValidationAttribute
    {
        private string[] myAuthors;

        public ValidAuthorAttribute(string[] authors)
        {
            myAuthors = authors;
        }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var strval = value.ToString();
                foreach (var t in myAuthors)
                {
                    if (strval == t)
                        return true;

                }
            }
            return false;
        }
    }
}