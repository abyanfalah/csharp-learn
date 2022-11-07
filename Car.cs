class Car
{
	public string model;
	public int make;

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
}