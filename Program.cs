using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.Write("ENTERpassword : ");
        string passwordStr = Console.ReadLine();
        int[] Password = Array.ConvertAll(passwordStr.ToCharArray(), c => (int)Char.GetNumericValue(c));
        Console.Write("ENTER  : ");
        string group = Console.ReadLine().ToUpper();

        bool TrueorFalse = false;

        if (Password[5] % 3 == 0 && Password[4] != 1 && Password[4] != 3 && Password[4] != 5 && Password[2] >= 6 && Password[2] != 8 && group == "CIA")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }                              
        }

        if (Password[0] >= 4 && Password[0] <= 7 && Password[3] % 2 == 0 && Password[3] != 6 && Password[1] % 2 != 0 && group == "FBI")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }           
        }
        if (Password[5] >= 1 && Password[5] <= 6 && Password[5] != 4 && Password[3] % 3 == 0 && Password[3] % 2 != 0 && Password.Contains(7) && group == "NSA")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }            
        }
        if (TrueorFalse == false)
        {
            Console.Write("false");
        }
    }
}
