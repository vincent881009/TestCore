using System;

namespace CoreTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ////冒泡
            //var list = Maopao();
            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            ////测试Class继承关系
            ClassB classC = new ClassC();
            classC.AddMothod();
            Console.ReadLine();

        }

        public static int[] Maopao()
        {
            int[] arr = new int[] { 2, 3, 5, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
