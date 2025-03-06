using System;
using System.Collections.Generic;

class Figura
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura.");
    }
}

class Circulo : Figura
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo.");
    }
}

class Cuadrado : Figura
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado.");
    }
}

class Program
{
    static void Main()
    {
        List<Figura> figuras = new List<Figura> { new Circulo(), new Cuadrado(), new Figura() };

        foreach (var figura in figuras)
        {
            figura.Dibujar();
        }
    }
}
