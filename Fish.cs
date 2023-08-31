using AnimalSpace;
namespace FishN;
internal class Fish : Animal {
    private float weight;
    public float Weight {
        get => weight;
        set{if(value > 0) weight = value; else throw new Exception("Ceki 0 ve ya az ola bilmez");}
    }
    public Fish(string nickname,int age,Gender_enum gender,float energy,float price, float weight)
    : base(nickname,age,gender,energy,price) {
        Weight = weight;
    }
    public Fish(string nickname,int age,Gender_enum gender,float price)
    : base(nickname,age,gender,100,price) {}
    
    public override void Eat()
    {
        Console.WriteLine("Fish is eating");
        weight += (float)0.05;
        MealGiven+=1;
    }
    public override void Sleep()
    {
        Console.WriteLine("Fish is Sleeping");
        Energy+=20;
    }
    public override void Play()
    {
        Console.WriteLine("Fish is playing");
        Energy -= 15;
    }
    public override string ToString()
    {
        return base.ToString() + $", Cekisi: {weight} kg";
    }
}