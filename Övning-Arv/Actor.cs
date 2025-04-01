using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Arv;
internal class Actor
{

    public Actor(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    public string Name { get; set; }
    public int BirthYear { get; set; }

}
