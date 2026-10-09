Animal animal = new Animal();
Dog dog = new Dog();
dog.MakeSound();

class Animal {
  public Animal() {
      Console.WriteLine("Animal constructor");
  }

  public virtual void MakeSound() {
      Console.WriteLine("Animal makes a sound");
  }

};

class Dog : Animal {
    public Dog() : base() {
        Console.WriteLine("Dog constructor"); 
    }

    public override void  MakeSound() {
        base.MakeSound();
        Console.WriteLine("Woof!");
    }
};