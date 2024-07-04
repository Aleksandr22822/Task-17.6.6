using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6._6
{
    public interface IСalculateInterest
    {
        double CalculateInterest(double balance, double intersect);
    }

    sealed class СalculateInterestOrdinary : IСalculateInterest
    {
        public double CalculateInterest(double balance, double intersect)
        {
            double result = balance * intersect / 2000;
            if (result < 5 && result > 0) { return result = 5; }
           
           else if (result > 10) { return result = 10; }    
            else { return result; } 
        }
    }

    sealed class СalculateInterestSelery : IСalculateInterest
    {
        public double CalculateInterest(double balance, double intersect)
        {
            double result = balance * intersect / 2000;
            if (result < 5 && result > 0) { return result = 6; }

            else if (result > 10) { return result = 12; }
            else { return result; }
        }
    }
}
