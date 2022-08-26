using System;
using System.Collections.Generic;
using System.Text;

namespace WieIsDeMol.Domain
{
    public static class MyExtensions
    {
        public static Gender toGender(this String gender)
        {
            return (Gender)Enum.Parse(typeof(Gender), gender);
        }
    }
}
