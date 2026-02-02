using System;
using System.Collections.Generic;

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility bikeUtility = new BikeUtility();
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine();
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine();
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            Console.WriteLine();

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the model");
                Console.WriteLine();
                string?model = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter the brand");
                Console.WriteLine();
                string?brand = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter the price per day");
                Console.WriteLine();
                int price = Convert.ToInt32(Console.ReadLine());

                bikeUtility.AddBikeDetails(model, brand, price);

                Console.WriteLine();
                Console.WriteLine("Bike details added successfully");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                SortedDictionary<string, List<Bike>> groupedBikes = bikeUtility.GroupBikesByBrand();
                Console.WriteLine();

                foreach (var brand in groupedBikes)
                {
                    Console.WriteLine(brand.Key);
                    Console.WriteLine();
                    foreach (Bike bike in brand.Value)
                    {
                        Console.WriteLine(bike.Model);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

public class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int PricePerDay { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;

        Bike bike = new Bike();
        bike.Model = model;
        bike.Brand = brand;
        bike.PricePerDay = pricePerDay;

        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

        foreach (Bike bike in Program.bikeDetails.Values)
        {
            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }
            groupedBikes[bike.Brand].Add(bike);
        }

        return groupedBikes;
    }
}