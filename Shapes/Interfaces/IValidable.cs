using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Interfaces
{
    internal interface IValidable
    {
        public static abstract bool IsValid(params double[] parameters);
    }
}
