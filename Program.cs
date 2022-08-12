using System;

namespace Parametros___clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IngresoDatosAlumnos("Juan Perez", 22, 'M');
            //IngresoDatosAlumnos("Marcos Ramirez", 32, 'M');

            CalculoIva();

            //sumaPorReferencia();

        }

        static void IngresoDatosAlumnos (String nombre, int edad, char sexo)
        {
            Console.WriteLine("Nombre: " + nombre +" |Edad: " + edad + " |Sexo:" + sexo);
        }

        static void CalculoIva() //cambiar a parametros por referencia
        {
            const float IVA = 0.12F;
            Console.WriteLine("ingrese precio del producto_");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cantidad del producto a comprar_");
            double cantidad = double.Parse(Console.ReadLine());

            IVAporProducto(out double totalIva,precio,cantidad,IVA);
            Console.WriteLine(String.Format("IVA por pagar: {0:C2}", totalIva));

        }

        static void IVAporProducto(out double totalIva, double Precio, double Cantidad, float IVA) {
            totalIva = Precio * Cantidad * IVA;
        }

        static void sumaPorReferencia()
        {
            Console.WriteLine("ingrese limite");
            int limite = int.Parse(Console.ReadLine());
            Factorial(out double suma, limite);
            Console.WriteLine("Total: " + suma);
        }

        private static void Factorial(out double suma, int limite)
        {
            double sumador = 0;
            for(int i = 0; i<= limite; i++)
            {
                sumador += i;
            }

            suma = sumador;
        }
    }
}
