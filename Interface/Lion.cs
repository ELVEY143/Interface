using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface;

public class Lion : Animal
{
    public Lion()
    {
        _name = "Алекс";
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
        Console.WriteLine($"Лев {Name} рычит");
        Console.WriteLine();
    }
}