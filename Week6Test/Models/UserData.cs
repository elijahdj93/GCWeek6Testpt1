using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Test.Models
{
    public class UserData
    {
        private double num1;
        private double num2;

        public double Num1
        {
            set { num1 = value; }
            get { return num1; }
        }

        public double Num2
        {
            set { num2 = value; }
            get { return num2; }
        }

        public UserData()
        {
            Num1 = 0;
            Num2 = 0;
        }

        public UserData(double n1, double n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
    }
}