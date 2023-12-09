using WildFarm;
using WildFarm.Animals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;


Farm farm = new Farm();

string animalInput = Console.ReadLine();
while (animalInput != "End")
{

    Animal animal = farm.ReadAnimal(animalInput);
    farm.AddAnimal(animal);
    Console.WriteLine(animal.Talk());

    string foodInput = Console.ReadLine();
    Food food = farm.ReadFood(foodInput);


    try
    {
        farm.FeedAnimal(animal, food);

    }
    catch (ArgumentException)
    {
        Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
    }

    animalInput = Console.ReadLine();

}

foreach (Animal currentAnimal in farm.Animals)
{
    Console.WriteLine(currentAnimal);
}