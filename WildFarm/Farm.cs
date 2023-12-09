using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;


namespace WildFarm;

public class Farm
{
    private List<Animal> _animals = new();

    public IReadOnlyCollection<Animal> Animals => _animals.AsReadOnly();
    // тук добавяме животното 
    public void AddAnimal(Animal animal)
    {

        _animals.Add(animal);

    }
    public Animal ReadAnimal(string animalInput)
    {
        string[] animalsParams = animalInput.Split().ToArray();

        if (animalsParams[0] == "Cat")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            string livingRegion = animalsParams[3];
            string breed = animalsParams[4];

            Cat cat = new Cat(name, weight, livingRegion, breed);

            return cat;


        }
        else if (animalsParams[0] == "Tiger")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            string livingRegion = animalsParams[3];
            string breed = animalsParams[4];

            Tiger tiger = new Tiger(name, weight, livingRegion, breed);

            return tiger;
        }
        else if (animalsParams[0] == "Owl")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            double wingSize = double.Parse(animalsParams[3]);


            Owl owl = new Owl(name, weight, wingSize);

            return owl;
        }
        else if (animalsParams[0] == "Hen")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            double wingSize = double.Parse(animalsParams[3]);


            Hen hen = new Hen(name, weight, wingSize);
            return hen;
        }
        else if (animalsParams[0] == "Mouse")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            string livingRegion = animalsParams[3];


            Mouse mouse = new Mouse(name, weight, livingRegion);

            return mouse;
        }
        else if (animalsParams[0] == "Dog")
        {
            string name = animalsParams[1];
            double weight = double.Parse(animalsParams[2]);
            string livingRegion = animalsParams[3];


            Dog dog = new Dog(name, weight, livingRegion);

            return dog;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public Food ReadFood(string foodInput)
    {
        string[] foodParams = foodInput.Split().ToArray();
        string foodName = foodParams[0];
        int foodQuantity = int.Parse(foodParams[1]);

        if (foodName == "Vegetable")
        {
            return new Vegetable(foodQuantity);
        }
        else if (foodName == "Fruit")
        {
            return new Fruit(foodQuantity);
        }
        else if (foodName == "Meat")
        {
            return new Meat(foodQuantity);
        }
        else if (foodName == "Seeds")
        {
            return new Seeds(foodQuantity);
        }
        else
        {
            throw new ArgumentException();
        }

    }
    public void FeedAnimal(Animal animal, Food food)
    {
        if (animal.GetType().Name == "Hen")
        {
            animal.Weight += food.Quantity * 0.35;
        }
        else if (animal.GetType().Name == "Owl")
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException();
            }
            animal.Weight += food.Quantity * 0.25;
        }
        else if (animal.GetType().Name == "Mouse")
        {

            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
            {
                throw new ArgumentException();
            }
            animal.Weight += food.Quantity * 0.10;
        }
        else if (animal.GetType().Name == "Cat")
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                throw new ArgumentException();
            }
            animal.Weight += food.Quantity * 0.30;
        }
        else if (animal.GetType().Name == "Dog")
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException();
            }
            animal.Weight += food.Quantity * 0.40;
        }
        else if (animal.GetType().Name == "Tiger")
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException();
            }
            animal.Weight += food.Quantity * 1.00;
        }
        animal.FoodEaten += food.Quantity;

    }

}
