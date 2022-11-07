class Car
{
	public string model;
	public int make;

	private int hp = 500;

	public Car(string carModel, int carMake)
	{
		model = carModel;
		make = carMake;
	}

	public void startEngine()
	{
		Console.WriteLine("engine started");
	}

	public void WOT()
	{
		Console.WriteLine("Top speed reached");
	}


	public static void Start()
	{
		Car car = new Car("mustang", 2000);
		Console.WriteLine(car.hp);
	}
}