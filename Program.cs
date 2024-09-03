using System;

namespace OperacionesMatematicasCS
{
    public abstract class Operaciones
    {
        public abstract double Sumar(double a, double b);
        public abstract double Restar(double a, double b);
        public abstract double Multiplicar(double a, double b);
        public abstract double Dividir(double a, double b);
        public abstract double Potenciar(double a, double b);
        public abstract double Raiz(double a);
        public abstract double OperacionAdicional(double a, double b);
    }

    public class OperacionesMatematicas : Operaciones
    {
        public override double Sumar(double a, double b) => a + b;
        public override double Restar(double a, double b) => a - b;
        public override double Multiplicar(double a, double b) => a * b;
        public override double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }
        public override double Potenciar(double a, double b) => Math.Pow(a, b);
        public override double Raiz(double a)
        {
            if (a < 0) throw new ArgumentException("No se puede calcular la raíz de un número negativo.");
            return Math.Sqrt(a);
        }
        public override double OperacionAdicional(double a, double b)
        {
            if (a == 0 || b == 0) throw new ArgumentException("Los valores no pueden ser cero.");
            return (1 / a) * (1 / b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var operaciones = new OperacionesMatematicas();

                Console.Write("Ingrese el primer número (máx. 6 dígitos): ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número (máx. 6 dígitos): ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Suma: {operaciones.Sumar(num1, num2)}");
                Console.WriteLine($"Resta: {operaciones.Restar(num1, num2)}");
                Console.WriteLine($"Multiplicación: {operaciones.Multiplicar(num1, num2)}");
                Console.WriteLine($"División: {operaciones.Dividir(num1, num2)}");
                Console.WriteLine($"Potencia: {operaciones.Potenciar(num1, num2)}");
                Console.WriteLine($"Raíz de {num1}: {operaciones.Raiz(num1)}");
                Console.WriteLine($"Operación Adicional: {operaciones.OperacionAdicional(num1, num2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}