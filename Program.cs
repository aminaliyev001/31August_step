using AnimalSpace;
using Pet;
using CatN;
using DogN;
using BirdN;
using FishN;

Cat cat1 = new Cat("Amin",2,Gender_enum.Male,200);
cat1.Play();
cat1.Play();
cat1.Eat();
cat1.Eat();

PetShop petshop = new PetShop("MyShop");
petshop.newAnimal(cat1);
cat1.Eat();

Dog dog1 = new Dog("Tony",0,Gender_enum.Male,600,0);
dog1.Play();
dog1.Play();

petshop.newAnimal(dog1);

Fish fish1 = new Fish("Salmon",3,Gender_enum.Male,100,200,2);
fish1.Play();
fish1.Play();
fish1.Eat();
petshop.newAnimal(fish1);

Bird bird1 = new Bird("Cik cik",1,Gender_enum.Female,50,200,30);
bird1.Play();
petshop.newAnimal(bird1);


petshop.printAllAnimals();
Console.WriteLine();
Console.WriteLine(petshop);
petshop.removeByNickName("Salmon");


Console.WriteLine($"Total value of animals: {petshop.getTotalValueOfAnimals()}");