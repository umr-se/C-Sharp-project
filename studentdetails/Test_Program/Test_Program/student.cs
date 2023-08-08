using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Program
{
    class student
    {
        public string name;
        public string program;
        public student(string aName)
        {
            name = aName;
        }
        public bool Forcheck()
        {
            if(name == "UMER")
            {
                return true;
            }
            return false;
        }
        

    }
}
