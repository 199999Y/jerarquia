using System;

interface ITrabajador
{
    void Trabajar();
}

abstract class Empleado : ITrabajador
{
    public string Nombre { get; set; }

    public abstract void MostrarCargo();

    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} está trabajando.");
    }
}

class Programador : Empleado
{
    public override void MostrarCargo()
    {
        Console.WriteLine($"{Nombre} es programador.");
    }
}

class Program
{
    static void Main()
    {
        Programador dev = new Programador { Nombre = "Lucía" };
        dev.MostrarCargo();
        dev.Trabajar();
    }
}
