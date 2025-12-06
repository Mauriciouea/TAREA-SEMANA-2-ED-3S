using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        private double _radio; // Campo privado para encapsular el radio

        // Propiedad para acceder y modificar el radio con validación
        public double Radio
        {
            get { return _radio; }
            set
            {
                if (value > 0)
                    _radio = value;
                else
                    throw new ArgumentException("El radio debe ser positivo.");
            }
        }

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        // Método para calcular el perímetro (circunferencia) del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    // Clase para representar un Rectángulo
    public class Rectangulo
    {
        private double _ancho; // Campo privado para encapsular el ancho
        private double _alto;  // Campo privado para encapsular el alto

        // Propiedad para acceder y modificar el ancho con validación
        public double Ancho
        {
            get { return _ancho; }
            set
            {
                if (value > 0)
                    _ancho = value;
                else
                    throw new ArgumentException("El ancho debe ser positivo.");
            }
        }

        // Propiedad para acceder y modificar el alto con validación
        public double Alto
        {
            get { return _alto; }
            set
            {
                if (value > 0)
                    _alto = value;
                else
                    throw new ArgumentException("El alto debe ser positivo.");
            }
        }

        // Constructor para inicializar ancho y alto
        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return Ancho * Alto;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }

}