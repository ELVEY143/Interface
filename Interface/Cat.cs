using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface;

public class Cat : Animal
{
    public Cat()
    {
        _name = "Том";
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public override void GetVoice()
    {
        Console.WriteLine();
        Console.WriteLine($"Кот {Name} мяукает");
        Console.WriteLine();
    }
}