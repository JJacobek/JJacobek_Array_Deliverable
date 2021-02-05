using System;

namespace JJacobek_Array_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a array with 25 iterations");
            const int SIZE = 26;
            int[] number = new int[SIZE];
            number[0] = 0;
            number[1] = 1;
            number[2] = 2;
            number[3] = 3;
            number[4] = 4;
            number[5] = 5;
            number[6] = 6;
            number[7] = 7;
            number[8] = 8;
            number[9] = 9;
            number[10] = 10;
            number[11] = 11;
            number[12] = 12;
            number[13] = 13;
            number[14] = 14;
            number[15] = 15;
            number[16] = 16;
            number[17] = 17;
            number[18] = 18;
            number[19] = 19;
            number[20] = 20;
            number[21] = 21;
            number[22] = 22;
            number[23] = 23;
            number[24] = 24;
            number[25] = 25;
            foreach (int val in number)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
