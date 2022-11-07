class Animal
{
	public virtual void breath()
	{
		Console.WriteLine("*breaths");
	}

	public virtual void makeSound()
	{
		Console.WriteLine("default sound.wav");
	}
}

class Cat : Animal
{
	private string name;
	public Cat(string name)
	{
		this.name = name;
	}

	public override void makeSound()
	{
		Console.WriteLine($"meow, im {this.name}");
	}
}

class Dog : Animal
{
	private string name;
	public Dog(string name)
	{
		this.name = name;
	}

	public override void makeSound()
	{
		Console.WriteLine($"woof, im {this.name}");
	}
}