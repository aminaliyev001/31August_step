using System.Runtime.InteropServices;
using AnimalSpace;
namespace CatN;
internal class Cat : Animal {
    private int usag_sayi;
    public int usagSayi {
        get => usag_sayi;
        set {if(value >= 0)usag_sayi = value; else throw new Exception("0-dan az ola bilmez pisikin usaglarinin sayi");}
    }
    public Cat(string nickname,int age,Gender_enum gender,float energy,float price, int usag)
    : base(nickname,age,gender,energy,price) {
        usagSayi = usag;
    }
    public Cat(string nickname,int age,Gender_enum gender,float price)
    : base(nickname,age,gender,100,price) {
        usagSayi = 0;
    }
    public override void Eat()
    {
       Console.WriteLine("Cat is eating ...");
       MealGiven+=1;
       Price += 10;
       Energy+=20;
    }
    public override void Sleep()
    {
        Console.WriteLine("Cat is Sleeping ...");
        Energy += 80;
    }
    public override void Play()
    {
        Console.WriteLine("Cat is playing ...");
        Energy -= 15;
    }
    public void dogumEledi() {
        usagSayi+=1;
        Energy -= 80;
    }
    public override string ToString()
    {
        return base.ToString() + $", Usag sayi: {usag_sayi}";
    }
}