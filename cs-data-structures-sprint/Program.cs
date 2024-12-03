//Console.WriteLine("Your code can go here, if you like");
using cs_data_structures_sprint.Exercises;
//Exercise1.PrintExesAndOhs();
LinkedList<string> cars = new LinkedList<string>();
cars.AddLast("Ford");
cars.AddLast("Kia");
cars.AddLast("BMW");
cars.AddLast("Lexus");
cars.AddLast("Skoda");
cars.AddLast("Mercedes");
cars.AddLast("Nissan");

foreach (string car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine("\n\n\n");
Exercise3.SwapElementPosition(cars, 1, 5);
foreach (string car in cars)
{
    Console.WriteLine(car);
}

//Exercise2.PrintFirstAndLast<string>(cars);

////Exercise2.PrintFirstAndLast(cars);

//int[] intValues = { 1, 4, 6, 7, 8 };
//LinkedList<int> values = new LinkedList<int>(intValues);
//values.AddLast(10);
//values.AddBefore(values.Last, 200);
//Exercise2.PrintFirstAndLast(values);

//LinkedList<Car> newCars = new LinkedList<Car>();
//newCars.AddLast(new Car("Ford", "Icon", "Petrol"));
//newCars.AddLast(new Car("Kia", "Model1", "Disel"));
//newCars.AddLast(new Car("Nissan", "ModelA", "Petrol"));
//newCars.AddLast(new Car("Skoda", "ModelX", "Disel"));

//Exercise2.PrintFirstAndLast(newCars);

