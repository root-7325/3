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
        for (int i = 0; i < 3; i++)
        {

            try
            {
                int flat = Convert.ToInt32(Console.ReadLine()) - 1;
                if (flat >= 10 || flat <= 0) throw new Exception("Wrong number!");

                System.Console.WriteLine(surname[flat]);
            }

            catch (Exception x)
            {
                System.Console.WriteLine(x.Message);
            }

        }

        Console.ReadKey(true);
    }
}