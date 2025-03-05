using System;

class Vehiculo
{
    public string Marca { get; set; }
    public int Año { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine($"Vehículo: {Marca}, Año: {Año}");
    }
}

class Auto : Vehiculo
{
    public int Puertas { get; set; }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Auto: {Marca}, Año: {Año}, Puertas: {Puertas}");
    }
}

class Program
{
    static void Main()
    {
        Auto miAuto = new Auto { Marca = "Toyota", Año = 2022, Puertas = 4 };
        miAuto.MostrarDetalles();
    }
}

