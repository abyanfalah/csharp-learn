internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// int result = sum(100, 400);
		// int result = sum(num2: 45, num1: 15);
		// double result2 = sum(45.5, 15.9);
		// Console.WriteLine(result);
		// Console.WriteLine(result2);

		Car bmw = new Car(carMake: 2001, carModel: "M3 GTR");
		Console.WriteLine(bmw.model);
		Console.WriteLine(bmw.make);
		bmw.startEngine();
		bmw.WOT();

	}

	static int addFive(int num)
	{
		return num + 5;
	}

	static int sum(int num1, int num2)
	{
		return num1 + num2;
	}

	static double sum(double num1, double num2)
	{
		return num1 + num2;
	}



	private static void log(string word)
	{
		Console.WriteLine(word);
	}

	static void age()
	{

		Console.Write("What is your age right now? ");

		int age = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("Your age is: " + age);

		Console.ReadLine();
		Console.Clear();

		Console.WriteLine("asdf".Length);
		Console.WriteLine("asdf".ToUpper());
	}

	static void array()
	{
		string[] cars = {
			"mazda",
			"bmw",
			"chevy",
		};

		// for (int i = 0; i < cars.Length; i++)
		// {
		// 	Console.WriteLine(cars[i]);
		// }

		foreach (string car in cars)
		{
			Console.WriteLine(car);
		}

		Console.WriteLine("============");

		Array.Sort(cars);

		foreach (string car in cars)
		{
			log(car);
		}
	}
}
