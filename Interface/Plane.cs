using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Plane : IFlyable
{
    public string Name { get; set; }
    public Plane()
    {
        Name = "Штурмовик";
    }
    public void Fly()
    {
        Console.WriteLine();
        Console.WriteLine($"Самолёт-{Name} летает");
        Console.WriteLine();
    }
}