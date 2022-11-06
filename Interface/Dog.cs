using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface;

public class Dog : Animal
{
    public Dog()
    {
        _name = "Мухтар";
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
        Console.WriteLine($"Пёс {Name} гавкает");
        Console.WriteLine();
    }
}