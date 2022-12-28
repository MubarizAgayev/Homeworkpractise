using ServiceLayer.Service.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class CalculateService : ICalculateService
    {
        public int MultiplyArrayItems(int[] arr)
        {
            int result = 1;
            foreach(var item in arr)
            {
                if(item>1 && item < 20)
                {
                    result *= item;
                }              
            }
            return result;
        }

        public int SquareOfSumArrayItems(int[] arr)
        {
            int sum= 0;
            foreach(var item in arr) 
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return (int)Math.Pow(sum, 2);
        }
    }
}
