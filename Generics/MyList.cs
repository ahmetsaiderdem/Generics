using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private static int objCount = 0;
        public MyList()
        {
            objCount++;
        }
        public int Count
        {
            get
            {
                return objCount;
            }
            
        }
    }
}
