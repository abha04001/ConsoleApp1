using System;
using System.ComponentModel.Design;

namespace upggift_6._2
{
    class program
    {
        public static void Main(string[] args)
        {
            int strostaTalet = Storsta(5, 9);
            Console.WriteLine("det är största talet är " + strostaTalet);

        }
        static int Storsta(int tal1, int tal2)
        {
            if (tal1 > tal2)
                return tal1;


            else
            {
                return tal2;
            }
        
        }
     

            
    }
}