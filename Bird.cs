using AnimalSpace;
namespace BirdN;
internal class Bird : Animal {
    private float fly_speed;
    public float flySpeed {
        get => fly_speed;
        set {if(fly_speed >= 0) fly_speed = value; else throw new Exception("0-dan asagi ola bilmez suret");}
    }
    public Bird(string nickname,int age,Gender_enum gender,float energy,float price,float fly_speed)
    : base(nickname,age,gender,energy,price) {
        flySpeed = fly_speed;
    }
    public Bird(string nickname,int age,Gender_enum gender,float price)
    : base(nickname,age,gender,100,price) {}
    
     public override void Eat()
    {
       Console.WriteLine("Bird is eating ...");
       MealGiven+=1;
       Price += 5;
       Energy+=10;
    }
    public override void Sleep()
    {
        Console.WriteLine("Bird is Sleeping ...");
        Energy += 85;
    }
    public override void Play()
    {
        Console.WriteLine("Bird is playing ...");
        Energy -= 5;
    }
    public override string ToString()
    {
        return base.ToString() + $", Qusun ucma sureti: {fly_speed} km/h";
    }
}