using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CountPi
{
    internal class Program
    {
        static int Accuracy;
        static double CircleRadius;
        static void Main(string[] args)
        {
            //1112410015蘇昱臣
            Console.WriteLine("請輸入圓週率的精度，不可小於4或大於15，超過不予計算");
            Accuracy=int.Parse(Console.ReadLine()); //精度放置全域變數
            if (CountPi(Accuracy) == -1) return;//計算Pi同時判斷精度是否正確
            Console.WriteLine("請輸入圓半徑為多少，可有小數點");
            CircleRadius = double.Parse(Console.ReadLine()); //圓半徑
            Console.WriteLine("Pi：{0:g}\n圓周長：{1:g}\n圓面積：{2:g}", CountPi(Accuracy), GetCircumference(CircleRadius),GetCircleArea(CircleRadius));

        }
        static double CountPi(int n)
        {
            if (n < 4 || n > 15)
            {
                Console.WriteLine("精度必須在 4 到 15 之間");
                return -1;
            }
            double Pi = 0, Step;
            for (int i = 0; i < n; i++)
            {
                Step = (Math.Pow(-1, i)) / ((2 * i) + 1);
                Pi += Step;
            }
            Pi *= 4;
            return Pi;
        }   
        static double GetCircumference(double r)
        {
            double Circumference = CountPi(Accuracy) * r; 
            return Circumference;
        }
        static double GetCircleArea(double r)
        {
            double CircleArea = CountPi(Accuracy) * r * r;
            return CircleArea;
        }
    }
    
}
