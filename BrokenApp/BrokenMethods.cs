using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokenApp
{
    public class BrokenMethods
    {

        public void SumOfTwoInts(int x, int y)
        {
            return x + y;
        }


        public int ProductOfTwoInts(int x, int y)
        {
            return x * y
        }


        private void PrintZipCode(int zip)
        {
            Console.WriteLine(zipCode);
        }


        public float SumOfTwoFloats(float x, float y)
        {
            float answer = x + y;
            return answer;
        }


        public double GetCircumference(double radius, double pi)
        {
            double circumference = 2pi * radius;
            return circumference;
        }


        private bool IsRightTriangle(int angleOne, int angleTwo)
        {
            if (angleOne + angleTwo == 180)
            {
                return true;
            }

            return False;
        }


        public void PrintFullName(string first, string last)
        {
            Console.Writeline($"{first} {last}");
        }


        public string CharSwitchCaseThatDoesNothing(char x)
        {
            string randomString;

            switch (x)
            {
                case 'a':
                    randomString = "A";
                    break;
                case 'b':
                    randomString = "B";
                    break;
                case 'c':
                case "d":
                    randomString = "C or D";
                    break;
                default:
                    break;
            }
        }
        

    }
}