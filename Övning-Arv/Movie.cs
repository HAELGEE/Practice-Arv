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
}
class Comedy : Movie
{
    public int NumberOfFunnyScenes { get; set; }

    public Comedy(string title, int runningTime, int numberOfFunnyScenes) : base(title, runningTime)
    {
        NumberOfFunnyScenes = numberOfFunnyScenes;
    }
}

class Action : Movie
{
    public int NumberOfShotsFired { get; set; }

    public Action(string title, int runningTime, int numberOfShotsFired) : base(title, runningTime)
    {
        NumberOfShotsFired = numberOfShotsFired;
    }
}

class SciFi : Movie
{
    public int NumberOfSpaceShips { get; set; }
    public SciFi(string title, int runningTime, int numberOfSpaceShips) : base(title, runningTime)
    {
        NumberOfSpaceShips = numberOfSpaceShips;
    }
}


