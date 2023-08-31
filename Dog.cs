using AnimalSpace;
namespace DogN;
internal class Dog : Animal {
    private int loyalty;
    public int Loyalty {
        get => loyalty;
        set {if(value > 0 && 100>=value)loyalty = value; else if(value > 100) loyalty = value;else if(0> value)loyalty = 0;}
    }
    public Dog(string nickname,int age,Gender_enum gender,float energy,float price)
    : base(nickname,age,gender,energy,price) {
        Loyalty = 0;
    }
    public Dog(string nickname,int age,Gender_enum gender,float price,int meal_given)
    : base(nickname,age,gender,100,price) {
        Loyalty = 0;
    }
    public override void Eat()
    {
       Console.WriteLine("Dog is eating ...");
       MealGiven+=1;
       Price += 15;
       Energy+=25;
    }
    public override void Sleep()
    {
        Console.WriteLine("Dog is Sleeping ...");
        Energy += 70;
    }
    public override void Play()
    {
        Console.WriteLine("Dog is playing ...");
        Energy -= 25;
        loyalty+=1;
    }
    public override string ToString()
    {
        return base.ToString() + $", Loyalty faizi: {loyalty}%";
    }

}