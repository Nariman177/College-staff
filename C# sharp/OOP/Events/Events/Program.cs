using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Calculate
    {
        public delegate void delegateOddNumber();
        public event delegateOddNumber eventOddNumber;

        public void add()
        {
            int ans;
            ans = 5 + 2;
            Console.WriteLine(ans.ToString());

            if((ans%2 !=0) && (eventOddNumber !=null))
            {
                eventOddNumber();
            }
            else
            {
                Console.WriteLine("Это четное число событие не сработало");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            cal.eventOddNumber += new Calculate.delegateOddNumber(EventMessage);
            cal.add();
        }
        static void EventMessage()
        {
           
            Console.WriteLine("Событие сработало это четное число");
        }
    }

   
}
