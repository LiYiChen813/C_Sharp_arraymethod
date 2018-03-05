using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,,] a = { {{ 1, 2, 3 },     //第0層
                           { 4, 5, 6,},
                           },

                          {{ 10, 11, 12 },  //第一層
                           { 13, 14, 15,},
                           },

                          {{ 20, 21, 22 },  //第二層
                           { 23, 24, 25,},
                           }


                        };                 //共三層

            Console.WriteLine("值是:" + a[0,0,1]);        //2    第0層 再來列 行
          //Console.WriteLine(a[1,3,1]);      錯誤 在索引值之外
            Console.WriteLine("值是:" + a[1,1,2]);     //15
            Console.WriteLine("值是:" + a[2, 1, 2]);   //25

            Console.WriteLine();

            Console.WriteLine("GetUpperBound是獲取維度的~上界~");


            int max1 = a.GetUpperBound(0); // 第一維度 有3層 
            Console.WriteLine("這裡是 .層. ，即第一維度，共 3 層，但是是從0開始計，0~2，所以傳回"+max1); // 但傳回2

            int max2 = a.GetUpperBound(1); // 第2維度 有2列
            Console.WriteLine("這是 .列.，也就是第二維度，共 2 列，0.1，所以傳回"+max2);  //會傳回1

            int max3 = a.GetUpperBound(2); // 第3維度 有3行
            Console.WriteLine("這是 .行.，也就是第三維度，共 3 列，0.1.2，所以傳回" + max3);  //會傳回2




            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();



            int[,,] a1 = new int[3, 24, 16];
            Console.WriteLine("一開始先設定三維陣列有3層 24列 16行");
            int m1 = a1.GetUpperBound(0);
            int m2 = a1.GetUpperBound(1);
            int m3 = a1.GetUpperBound(2);

            Console.WriteLine("第一維度，層...有3層...0.1.2...傳回2..."+m1);
            Console.WriteLine("第二維度，列...有24列...0~23...傳回23..." + m2);
            Console.WriteLine("第三維度，行...有16行...0~15...傳回15..." + m3);


            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("C#的 Length 方法統一就是算總長度(總元素數)");
            int[] score1 = { 59, 60, 100 };
            int length1 = score1.Length;
            Console.WriteLine("長度，即元素數量:" + length1);


            int[,] score2 = new int[2,4];/*{ { 1,2,3,8},
                                          { 4,5,6,9} };*/
            int length2 = score2.Length;
            Console.WriteLine("長度，即元素數量:" + length2);

    
            int[,,] score3 = new int[2, 4,3];
            int length3 = score3.Length;
            Console.WriteLine("長度，即元素數量:" + length3);

            Console.WriteLine("C#的 GetLength 方法 是指定維度的長度(元素數)");

            int[,,] score4 = new int[2, 3, 4];
            int value1 = score4.GetLength(0);    //2
            int value2 = score4.GetLength(1);    //3
            int value3 = score4.GetLength(2);    //4
            Console.WriteLine(value1+","+value2+","+value3);
        }
    }
}
