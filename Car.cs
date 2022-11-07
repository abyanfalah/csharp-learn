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

	public void getpower()
	{
		Console.WriteLine($"{model} has power of: {hp}hp");
	}

	public void setpower(int n)
	{
		Console.WriteLine("adding " + (n - hp) + " of power to " + model);
		this.hp = n;
		Console.WriteLine($"{model} power is now: {hp}hp");
	}


	public static void Start()
	{
		Car car = new Car("mustang", 2000);
		Console.WriteLine(car.hp);
	}
}