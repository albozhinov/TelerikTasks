using System;
using System.Text;

namespace GirlsGoneWild
{
    class GirlsGoneWild
    {
        private static int kShirts;
        private static string lSkirts;
        private static int girls;
        private static int counter;
        private static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            kShirts = 3;        //int.Parse(Console.ReadLine());
            lSkirts = "baca";   //Console.ReadLine();
            girls = 2;          //int.Parse(Console.ReadLine());

            Girls(0);
        }

        private static void Girls(int index)
        {
            if (index == lSkirts.Length)
            {
                counter++;
                sb.AppendLine();
                return;
            }

            for (int i = 0; i < girls; i++)
            {
                Girls(index + 1);
            }


        }
    }
}
