using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Support
{
    public class Pair<Type1, Type2>
    {
        public Type1 First { get; set; }

        public Type2 Second { get; set; }
    }
}
