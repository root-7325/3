using System;
class ApartmentBuilding
{
    static void Main()
    {
        string[] surname = new string[10];
        Console.WriteLine("Enter 10 surnames");
        for (int i = 0; i < 10; i++)
        {
            surname[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter 3 flats");
        int flat = 0;
        int x = 0;
        for (int i = 0; i < 3; i++)
        {

            try
            {
                flat = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            catch (System.FormatException)
            {
                x++;
            }
            finally
            {
                if (flat > 9 || x == 1)
                {
                    Console.WriteLine("Wrong number!");
                    x--;
                    i--;
                }

                else
                {
                    Console.WriteLine(surname[flat]);
                }
            }

        }
        Console.ReadKey(true);
    }
}
