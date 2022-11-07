internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		int result = addFive(100);
		Console.WriteLine(result);



	}

	static int addFive(int num)
	{
		return num + 5;
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