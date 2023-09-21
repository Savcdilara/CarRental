using CarRental.Enums;

namespace Lecture_1.Part_2.CarRentalPro;


class Program

{
    static List<Car> availableCars = new();
    static List<Car> rentedCars = new() ;
    static List<Car> cars = new List<Car>();


    static void Main(string[] args)
    {
        Car car1 = new Car("Honda", "Civic", 40000, DateTime.Now, Status.NewCar);
        Car car2 = new Car("Toyota", "Corolla", 10000, DateTime.Now, Status.NewCar);
        Car car3 = new Car("Fiat", "Egea", 40000, DateTime.Now, Status.NewCar);
        Car car4 = new Car("Ford", "Focus", 80000, DateTime.Now, Status.UsedCar);

        availableCars.Add(car1);
        availableCars.Add(car2);
        availableCars.Add(car3);
        availableCars.Add(car4);


        Console.WriteLine("Welcome to the Car Rental System");
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Rent a car");
            Console.WriteLine("2. Return a car");
            Console.WriteLine("3. List available cars");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RentCar();
                    break;
                case "2":
                    ReturnCar();
                    break;
                case "3":
                    ListAvailableCars();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RentCar()
    {
        Console.WriteLine("Enter the car you want to rent: ");
        for (int i = 0; i < availableCars.Count; i++)
        {
            Console.WriteLine($"{i + 1}- {availableCars[i].Brand}");
        }
        try
        {
            int carToRent = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Car Rented {availableCars[carToRent].Brand} ,  {availableCars[carToRent].Model}  , {availableCars[carToRent].Km}  , {availableCars[carToRent].ProductTime}  , {availableCars[carToRent].Status}");
            rentedCars.Add(availableCars[carToRent]);
            availableCars.RemoveAt(carToRent);
        }
        catch
        {
            Console.WriteLine("Sorry, the selected car is not available.");
        } 
    }

    static void ReturnCar()
    {
        Console.WriteLine("Enter the car you want to return: ");
        for(int i = 0;i < availableCars.Count;i++)
        {
            Console.WriteLine($"{i + 1} - {rentedCars[i].Brand} ");

        }
        try
        {
            int carToReturn = Convert.ToInt32(Console.ReadLine()) - 1;
            
            if (carToReturn >= 0 && carToReturn < rentedCars.Count)
            {
                availableCars.Add(rentedCars[carToReturn]);
                rentedCars.RemoveAt(carToReturn);
                Console.WriteLine("You have returned a " +  carToReturn);
            }
            else 
            {
                Console.WriteLine("Sorry, you did not rent this car from us.");
            }
        }
        catch
        {
            Console.WriteLine("Sorry,please try again");
        }
        

    }

    static void ListAvailableCars()
    {
        Console.WriteLine("Available cars:");
        foreach (var car in availableCars)
        {
            Console.WriteLine(car);
        }
    }
}