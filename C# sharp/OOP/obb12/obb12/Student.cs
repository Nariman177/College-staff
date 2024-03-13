using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obb12
{
    class Student
    {
        private string name;
        private string surname;
        private string recordBockNumber;
        public Student(string name, string surname, string recordBockNumber)
        {
            this.name = name;
            this.surname = surname;
            this.recordBockNumber = recordBockNumber;
        }
        public string getName()
        {
            return this.name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public string getRecordBookNumber()
        {
            return this.recordBockNumber;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }
        public void setRecordBookNumber(string recordBockNumber)
        {
            this.recordBockNumber = recordBockNumber;
        }
    }
}
