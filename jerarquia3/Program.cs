using System;

class Persona
{
    public string Nombre { get; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
}

class Estudiante : Persona
{
    public int Grado { get; }

    public Estudiante(string nombre, int grado) : base(nombre)
    {
        Grado = grado;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Estudiante: {Nombre}, Grado: {Grado}");
    }
}

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante("Carlos", 10);
        estudiante.MostrarInfo();
    }
}
