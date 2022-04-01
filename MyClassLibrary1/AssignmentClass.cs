using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public class AssignmentClass
    {
        public string gradeCalculate(int score) {
            if(score > 100)
                return "A";
            else if (score >= 70 && score < 75)
                return "B";
            else if (score >= 60 && score < 65)
                return "C";
            else if (score >= 50 && score < 55)
                return "D";
            else
                return "F";
        }
        public double getDistance(int x1, int y1, int x2, int y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(sum);
            return Math.Round(result, 2);
        }
        public int getFactorial(int n)
        {
            int z;
            int sum = 1;
            for (z = 1; z <= n; z++)
            {
                sum *= z;
            }
            return z;
        }
        public bool checkPassword(string abc12345)
        {
                return true;

        }
    }
}
