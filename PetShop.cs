using System.Collections;
using System.Dynamic;
using System.Runtime.CompilerServices;
using AnimalSpace;
using BirdN;
using CatN;
using DogN;
using FishN;

namespace Pet;

internal class PetShop {
    private string name;
    public string Name {
        get => name;
        set {if(value.Length>2) name = value; else throw new Exception("Petshopun adi minimum 3 simvoldan ibaret olmalidir");}
    }
    private int heyvanlarin_sayi;
    public int HeyvanCount {
        get => heyvanlarin_sayi;
        set {if(value >= 0) heyvanlarin_sayi = value; else throw new Exception("Heyvanlarin sayi 0dan asagi ola bilmez");}
    }
    private Cat[] cats = new Cat[10];
    private Dog[] dogs = new Dog[10];
    private Fish[] fishes = new Fish[10];
    private Bird[] birds = new Bird[10];
        public void newAnimal(Animal animal) {
            if (animal is Cat catAdd){
                if (cats == null){
                    cats = new Cat[1];
                }
                else{
                    Cat[] newCats = new Cat[cats.Length + 1];
                    Array.Copy(cats, newCats, cats.Length);
                    cats = newCats;
                }
                cats[HeyvanCount] = catAdd;
                HeyvanCount += 1;
        } else if(animal is Dog dogAdd) {
            if (dogs == null){
                    dogs = new Dog[1];
                }
                else{
                    Dog[] newDogs = new Dog[dogs.Length + 1];
                    Array.Copy(dogs, newDogs, dogs.Length);
                    dogs = newDogs;
                }
                dogs[dogs.Length-1] = dogAdd;
                HeyvanCount += 1;
        }
        else if(animal is Fish fishAdd) {
            if (fishes == null){
                    fishes = new Fish[1];
                }
                else{
                    Fish[] newfishes = new Fish[fishes.Length + 1];
                    Array.Copy(fishes, newfishes, fishes.Length);
                    fishes = newfishes;
                }
                fishes[fishes.Length-1] = fishAdd;
                HeyvanCount += 1;
        }
        else if(animal is Bird birdAdd) {
            if (birds == null){
                    birds = new Bird[1];
                }
                else{
                    Bird[] newBirds = new Bird[birds.Length + 1];
                    Array.Copy(birds, newBirds, birds.Length);
                    birds = newBirds;
                }
                birds[birds.Length-1] = birdAdd;
                HeyvanCount += 1;
        }
        }
        public void printCats() {
            if(cats != null) {
                for(int i = 0;cats.Length > i;i++) {
                    if(cats[i] != null)
                    Console.WriteLine(cats[i]);
                }
            }
        }
        public void printDogs() {
            if(dogs != null) {
                for(int i = 0;dogs.Length > i;i++) {
                    if(dogs[i] != null)
                    Console.WriteLine(dogs[i]);
                }
            }
        }
        public void printFishes() {
            if(fishes != null) {
                for(int i = 0;fishes.Length > i;i++) {
                    if(fishes[i] != null)
                    Console.WriteLine(fishes[i]);
                }
            }
        }
        public void printBirds() {
            if(birds != null) {
                for(int i = 0;birds.Length > i;i++) {
                    if(birds[i] != null)
                    Console.WriteLine(birds[i]);
                }
            }
        }
        public void removeByNickName(string name) {
            if(cats.Any(animal => animal?.Nickname?.Contains(name, StringComparison.OrdinalIgnoreCase) == true)) {
                for(int i = 0;cats.Length > i;i++) {
                    if(cats[i] != null)
                        if(cats[i].Nickname == name)
                            {
                                Cat[] newcats = new Cat[cats.Length-1];
                                int it = 0;
                                for(int z = 0;cats.Length > z;z++) {
                                    if(cats[z].Nickname != name) {
                                        newcats[it] = cats[z];
                                        it+=1;
                                    }
                                }
                                cats = newcats;
                                HeyvanCount-=1;
                            }
                }
            } else if(dogs.Any(animal => animal?.Nickname?.Contains(name, StringComparison.OrdinalIgnoreCase) == true)) {
                for(int i = 0;dogs.Length > i;i++) {
                    if(dogs[i] != null)
                        if(dogs[i].Nickname == name)
                            {
                                Dog[] newdogs = new Dog[dogs.Length-1];
                                int it = 0;
                                for(int z = 0;cats.Length > z;z++) {
                                    if(dogs[z].Nickname != name) {
                                        newdogs[it] = dogs[z];
                                        it+=1;
                                    }
                                }
                                dogs = newdogs;
                                HeyvanCount-=1;
                            }
                }
            } else if(fishes.Any(animal => animal?.Nickname?.Contains(name, StringComparison.OrdinalIgnoreCase) == true)) {
                for(int i = 0;fishes.Length > i;i++) {
                    if(fishes[i] != null)
                        if(fishes[i].Nickname == name)
                            {
                                Fish[] newfishes = new Fish[dogs.Length-1];
                                int it = 0;
                                for(int z = 0;fishes.Length > z;z++) {
                                    if(fishes[z] != null && fishes[z].Nickname != name) {
                                        newfishes[it] = fishes[z];
                                        it+=1;
                                    }
                                }
                                fishes = newfishes;
                                HeyvanCount-=1;
                            }
                }
            } else if(birds.Any(animal => animal?.Nickname?.Contains(name, StringComparison.OrdinalIgnoreCase) == true)) {
                for(int i = 0;birds.Length > i;i++) {
                    if(birds[i] != null)
                        if(birds[i].Nickname == name)
                            {
                                Bird[] newbirds = new Bird[birds.Length-1];
                                int it = 0;
                                for(int z = 0;birds.Length > z;z++) {
                                    if(birds[z].Nickname != name) {
                                        newbirds[it] = birds[z];
                                        it+=1;
                                    }
                                }
                                birds = newbirds;
                                HeyvanCount-=1;
                            }
                }
            } else {
                Console.WriteLine($"{name} adli heyvan tapilmadi");
            }
        }
        public void deleteAllAnimals() {
            Array.Clear(fishes);
            Array.Clear(birds);
            Array.Clear(cats);
            Array.Clear(dogs);
        }
        public float getTotalValueOfAnimals() {
            float total = 0;
            if (cats != null)
                total += cats.Where(cat => cat != null).Sum(cat => cat.Price);

            if (dogs != null)
                total += dogs.Where(dog => dog != null).Sum(dog => dog.Price);

            if (birds != null)
                total += birds.Where(bird => bird != null).Sum(bird => bird.Price);

            if (fishes != null)
                total += fishes.Where(fish => fish != null).Sum(fish => fish.Price);


            return total;
        }
        public void printAllAnimals() {
            Console.WriteLine("Cats: ");
            printCats();
            Console.WriteLine();
            Console.WriteLine("Dogs: ");
            printDogs();
            Console.WriteLine("Fishes: ");
            printFishes();
            Console.WriteLine("Birds: ");
            printBirds();
        }
    public override string ToString()
    {
        return $"Petshop name: {name}, Heyvanlarin sayi: {heyvanlarin_sayi}";
    }
    public PetShop(string name) {
        Name = name;
    }
}