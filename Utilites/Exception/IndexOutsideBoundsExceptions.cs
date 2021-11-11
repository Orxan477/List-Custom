using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exception
{
   public class IndexOutsideBoundsExceptions:SystemException
    {
        public IndexOutsideBoundsExceptions(string message):base(message)
        {

        }
    }
}
