// Clase principal para demostrar el uso
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de las figuras
            Circulo circulo = new Circulo(5.0); // Radio de 5 unidades
            Rectangulo rectangulo = new Rectangulo(4.0, 6.0); // Ancho 4, Alto 6

            // Calcular y mostrar resultados para el círculo
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():F2}");

            // Calcular y mostrar resultados para el rectángulo
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Área: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro():F2}");
        }
    }