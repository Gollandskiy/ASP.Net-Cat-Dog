using Microsoft.AspNetCore.Mvc;

namespace DZ2_31._01._2024_.Controllers
{
    public class AnimalController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var dog = new Dog("Dog Sobaka");
            var cat = new Cat("Cat Kot");
            var animalViewModel = new AnimalViewModel { Dog = dog, Cat = cat };

            return View(animalViewModel);
        }

        [HttpPost]
        public IActionResult MakeSound(string animal)
        {
            Animal selectedAnimal;
            string animalLower = animal.ToLower();

            if (animalLower == "dog")
            {
                selectedAnimal = new Dog("Dog Sobaka");
            }
            else if (animalLower == "cat")
            {
                selectedAnimal = new Cat("Cat Kot");
            }
            else
            {
                selectedAnimal = null;
            }

            if (selectedAnimal != null)
            {
                selectedAnimal.MakeSound();
                return Content($"{selectedAnimal.Name} made a sound!");
            }
            else
            {
                return Content("Invalid animal type.");
            }
        }
    }
}
