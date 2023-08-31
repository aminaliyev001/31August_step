namespace AnimalSpace;
public enum Gender_enum {Male = 1, Female = 2}
internal abstract class Animal {
    private string nickname;
    public string Nickname {
        get => nickname;
        set {if(value.Length > 2) nickname = value; else throw new Exception("Nickname minimum 3 simvoldan ibaret olmalidir.");}
    }
    private int age;
    public int Age {
        get => age;
        set {if(value >= 0 ) age = value; else throw new Exception("Age minimum 0 yasdan basliyir.");}
    }
    public Gender_enum Gender {get;set;}
    private float energy;
    public float Energy {
        get => energy;
        set {if(value >= 0 && 100>=value) energy = value; else if(value > 100) energy = 100; else if(0>energy) energy = 0;}
    }
    private float price;
    public float Price {
        get => price;
        set {if(value > 0)price = value;else throw new Exception("Qiymeti 0-dan yuxari olmalidir.");}
    }
    private int meal_given;
    public int MealGiven {
        get => meal_given;
        set {if(value >= 0) meal_given = value; else throw new Exception("Minimum 0 ola biler");}
    }
    public Animal(string nickname,int age,Gender_enum gender,float price,float energy)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealGiven = 0;
    }
    public Animal (string nickname,int age,Gender_enum gender,float price) : this(nickname,age,gender,100,price){}
    public abstract void Play();
    public abstract void Eat();
    public abstract void Sleep();

    public override string ToString()
    {
        return $"Nickname: {nickname}, age: {age}, Gender: {Gender}, Price: {price}, Enerji: {energy}, {meal_given} defe yemek verilib";
    }
};