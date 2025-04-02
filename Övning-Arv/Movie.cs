using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Arv;
internal class Movie
{

    public Movie(string title, int runningTime)
    {
        Title = title;
        RunningTime = runningTime;
        GetActors();
    }


    public string Title { get; set; }
    public int RunningTime { get; set; }

    public List<Actor> Actors = new List<Actor>();

    void GetActors()
    {
        Actors.Add(new Actor("- Tom Cruise", 1970));
        Actors.Add(new Actor("- Arnold Schwarzenegger", 1955));
    }

    public virtual void ShowMovie()
    {
        Console.WriteLine($"Filmen {Title} är {RunningTime} min lång, och har följande skådespelare:");
        foreach (Actor actor in Actors)
        {
            Console.WriteLine($"{actor.Name} (född {actor.BirthYear})");
        }
        Console.WriteLine();
    }
}
class Comedy : Movie
{
    public int NumberOfFunnyScenes { get; set; }

    public Comedy(string title, int runningTime, int numberOfFunnyScenes) : base(title, runningTime)
    {
        NumberOfFunnyScenes = numberOfFunnyScenes;
    }


    public override void ShowMovie()
    {
        Console.WriteLine($"Filmen {Title} är {RunningTime} min lång, och har följande skådespelare:");
        foreach (Actor actor in Actors)
        {
            Console.WriteLine($"{actor.Name} (född {actor.BirthYear})");
        }
        Console.Write($"Filmen innehåller ");
        Console.WriteLine($"{NumberOfFunnyScenes} roliga scener.");
        Console.WriteLine("-----------------------------------------");
    }

}

class Action : Movie
{
    public int NumberOfShotsFired { get; set; }

    public Action(string title, int runningTime, int numberOfShotsFired) : base(title, runningTime)
    {
        NumberOfShotsFired = numberOfShotsFired;
    }
    public override void ShowMovie()
    {
        Console.WriteLine($"Filmen {Title} är {RunningTime} min lång, och har följande skådespelare:");
        foreach (Actor actor in Actors)
        {
            Console.WriteLine($"{actor.Name} (född {actor.BirthYear})");
        }
        Console.Write($"Filmen innehåller ");
        Console.WriteLine($"I filmen skjuts det {NumberOfShotsFired} gånger.");
        Console.WriteLine("-----------------------------------------");

    }
}

class SciFi : Movie
{
    public int NumberOfSpaceShips { get; set; }
    public SciFi(string title, int runningTime, int numberOfSpaceShips) : base(title, runningTime)
    {
        NumberOfSpaceShips = numberOfSpaceShips;
    }
    public override void ShowMovie()
    {
        Console.WriteLine($"Filmen {Title} är {RunningTime} min lång, och har följande skådespelare:");
        foreach (Actor actor in Actors)
        {
            Console.WriteLine($"{actor.Name} (född {actor.BirthYear})");
        }
        Console.Write($"Filmen innehåller ");
        Console.WriteLine($"Filmen innehåller minst {NumberOfSpaceShips} rymdskepp");
        Console.WriteLine("-----------------------------------------");

    }
}


