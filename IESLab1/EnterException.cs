using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESLab1
{
    class EnterException: Exception
    {
        private String NameException;

        public EnterException(String NameException)
        {
            this.NameException = NameException;
        }

        public override String ToString()
        {
            return NameException;
        }
    }
}
