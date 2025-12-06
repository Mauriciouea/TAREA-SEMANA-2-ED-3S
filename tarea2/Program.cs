using System;

// =======================
// Clase Círculo
// =======================
public class Circulo
{
    private double radio;

    public Circulo(double r)
    {
        radio = r;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// =======================
// Clase Rectángulo
// =======================
public class Rectangulo
{
    private double baseRect;
    private double altura;

    public Rectangulo(double b, double h)
    {
        baseRect = b;
        altura = h;
    }

    public double CalcularArea()
    {
        return baseRect * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}

// =======================
// Programa principal
// =======================
class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo
        Circulo c = new Circulo(5.0);
        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        // Crear un rectángulo
        Rectangulo r = new Rectangulo(10.0, 4.0);
        Console.WriteLine("\n=== RECTÁNGULO ===");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
    }
}
