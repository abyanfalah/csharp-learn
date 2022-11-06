internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// Console.Write("What is your age right now? ");

		// int age = Convert.ToInt16(Console.ReadLine());
		// Console.WriteLine("Your age is: " + age);

		// Console.ReadLine();
		// Console.Clear();

		// Console.WriteLine("asdf".Length);
		// Console.WriteLine("asdf".ToUpper());

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

	private static void log(string word)
	{
		Console.WriteLine(word);
	}
}