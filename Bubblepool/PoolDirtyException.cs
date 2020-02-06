using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblepool
{
    public class PoolDirtyException : Exception
    {
        public PoolDirtyException(String s) :
        base(s)
        {
        }
    }

}
