using System;
class MultiplayerHouse
{
    static void Main()
    {
        string[] familiya = new string[10];
        int kvartira = 0;
        int forexception = 0;
        Console.WriteLine("Input 10 familiy");
        for (int i = 0; i < 10; i++)
        {
            familiya[i] = Console.ReadLine();
        }

        Console.WriteLine("Input 3 kvartir");

        for (int i = 0; i < 3; i++)
        {

            try
            {
                kvartira = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            catch (System.FormatException)
            {
                forexception++;
            }

            if (kvartira > 9 || forexception == 1)
            {
                Console.WriteLine("Wrong number!");
                i--;
                if (forexception != 0)
                {
                    forexception--;
                }

            }

            else
            {
                Console.WriteLine(familiya[kvartira]);
            }

        }
        Console.ReadKey(true);
    }
}
