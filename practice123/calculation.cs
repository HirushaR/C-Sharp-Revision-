using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice123
{
    class calculation
    {
        //this is encalpusation class
        //save all the data in privert variable so other class can't accsess 
        private int age,c;
        public void setvalu(int ag)
        {
            //assign the values to the variable
            age = ag;
        }
        public int getage()
        {
            c = 2019 - age;
            //return the values 
            return c;
        }
    }
}
