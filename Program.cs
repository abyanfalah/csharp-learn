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
			"bmw",
			"chevy",
			"mazda"
		};

		for (int i = 0; i < cars.Length; i++)
		{
			Console.WriteLine(cars[i]);
		}
		Console.WriteLine(cars.Length);

	}
}