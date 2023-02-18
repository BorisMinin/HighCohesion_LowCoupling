using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion_LowCoupling.Services.Coupling
{
    public class AnimalService
    {
        #region low coupling:
        private readonly IAnimal _animal;

        public AnimalService(IAnimal animal)
        {
            _animal = animal;
        }

        public void MakeAnimalSound()
        {
            _animal.MakeSound();
        }

        #region high coupling:
        public void MakeCatSound()
        {
            Console.WriteLine("Мяу");
        }
        #endregion
    }
}
