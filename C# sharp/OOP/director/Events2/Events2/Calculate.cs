using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    internal class Calculate
    {
        public event delegateOddNumber eventOddNumber;
        public delegate void delegateOddNumber();
    }
    
    static void EventMessage()
    {
        Calculate cal = new Calculate();
        cal.eventOddNumber += new Calculate.delegateOddNumber(EventMessage);
        cal.add();

    }
}
