namespace DZ2_31._01._2024_
{
	public class Animal
	{
        public string Name { get; set; }
		public string Sound { get; set; }

		public virtual void MakeSound()
		{
			Console.WriteLine($"{Name} says {Sound}");
		}
	}

	public class Dog : Animal
	{
		public Dog(string name)
		{
			Name = name;
			Sound = "Woof";

        }
    }

	public class Cat : Animal
	{
		public Cat(string name)
		{
			Name = name;
			Sound = "Meow";

        }
    }

}
