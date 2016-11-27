using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Redo
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGameSystems myNintendo = new VideoGameSystems();
            myNintendo.HasControllers = true;
            myNintendo.HasWifi = true;
            myNintendo.HasCartridges = true;
            myNintendo.HasCD = false;
            myNintendo.HasDigitalDownload = true;
            VideoGameSystems myNintendoSwitch = new VideoGameSystems("NintendoSwitch");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nintendo's newest system is called the " + myNintendoSwitch + " and it comes out March of 2017!");
            Console.WriteLine("Does it take cartridges? " + myNintendo.HasCartridges);
            Console.WriteLine("How about Wifi? " + myNintendo.HasWifi);
            Console.WriteLine("Does it take CDs too? " + myNintendo.HasCD);
            Console.WriteLine();

            Superheroes mySuperHeroes = new Superheroes();
            mySuperHeroes.HasPowers = true;
            mySuperHeroes.HasAlterEgo = true;
            mySuperHeroes.HasLoveInterest = true;
            mySuperHeroes.HasSuperHeroCar = false;

            Console.WriteLine("Does my favorite Superheroe has a secret identity " + mySuperHeroes.HasAlterEgo);
            Console.WriteLine("Superpowers? " + mySuperHeroes.HasPowers);
            Console.WriteLine("Lois Lane is Superman's wife " + mySuperHeroes.HasLoveInterest);
            Console.WriteLine("Does everyone know who Superman is? Or is it a secret? " + mySuperHeroes.HasAlterEgo);
            Console.WriteLine("Batman has the Batmobile, does Supes have a car? " + mySuperHeroes.HasSuperHeroCar);
            Console.WriteLine();

            HorrorVillans myHorrorVillans = new HorrorVillans();
            myHorrorVillans.HasMovies = true;
            myHorrorVillans.HasMask = true;
            myHorrorVillans.HasSharpWepons = true;
            myHorrorVillans.HasMagicalProperties = false;

            Console.WriteLine("Does this villan have movies? " + myHorrorVillans.HasMovies);
            Console.WriteLine("How about a mask, do they wear one? " + myHorrorVillans.HasMask);
            Console.WriteLine("Don't really wanna know this, but are they stabby? " + myHorrorVillans.HasSharpWepons);
            Console.WriteLine("Okay, movies is plural. Do they just not die? Or does someone takes their place? " + myHorrorVillans.HasMagicalProperties);
            Console.WriteLine();

            Console.Read();


        }
    }
}
