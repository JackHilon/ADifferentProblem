using System;
using System.Collections.Generic;

namespace ADifferentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Different Problem
            // https://open.kattis.com/problems/different

            // solved but I get a Time Limit Exceeded error in kattis.com ????

            List<int> answers = new List<int>();
            var mycount = 3;
            
            for (int i = 0; i < mycount; i++)
            {
                //var numArr = EnterLine();
                var numArr = MySimple();

                var result = AbsoluteDifference(numArr[0], numArr[1]);
                answers.Add(result);
            }
            PrintList(answers);
        }
        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        private static int AbsoluteDifference(int a, int b)
        {
            return Math.Abs(a - b);
        }
        private static int[] EnterLine()
        {
            var arr = new int[2] { 0, 0};
            string[] strArr;
            var str = Console.ReadLine();

            try
            {
                strArr = str.Split(' ', 2);
                
                arr[0] = int.Parse(strArr[0]);
                arr[1] = int.Parse(strArr[1]);
                if(arr[0] <= 0 || arr[0] <= 0)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " || "+ ex.GetType().ToString());
                return EnterLine();
            }
            return arr;
        }
        private static int[] MySimple()
        {
            var str = Console.ReadLine();

            var strArr = str.Split(' ', 2);

            var arr = new int[2];
            arr[0] = int.Parse(strArr[0]);
            arr[1] = int.Parse(strArr[1]);

            return arr;
        }
    }
}
