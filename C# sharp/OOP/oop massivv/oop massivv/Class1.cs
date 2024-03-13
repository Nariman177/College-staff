using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_massivv
{
    internal class myClass
    {
        private int[] myArray = new int[] { 54 , 2 , 68 };

        public int this[int index]
        {
            set { myArray[index] = value; }
            get { return myArray[index]; }
        }
        
    }
}

