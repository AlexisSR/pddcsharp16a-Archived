using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory___Cano_Aguilar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Carro Electrico \n");
            AutomovilElectricidad Tesla = new AutomovilElectricidad("Tesla", "Rojo", 88, 12.5);
            Tesla.mostrarCaracteristicas();
            Console.WriteLine("Carro Gasolina \n");
            AutomovilGasolina BMW = new AutomovilGasolina("BMW", "Azul", 200, 12.5);
            BMW.mostrarCaracteristicas();
        }
    }

    public abstract class Automovil
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        protected double espacio;
        public Automovil(string modelo, string color, int
                         potencia, double espacio)
        {
            this.modelo = modelo;
            this.color = color;
            this.potencia = potencia;
            this.espacio = espacio;
        }
        public abstract void mostrarCaracteristicas();
    }


    public class AutomovilElectricidad : Automovil
    {
        public AutomovilElectricidad(string modelo, string
                                     color, int potencia, double espacio)
            : base(modelo,
                color, potencia, espacio)
        { }
        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil eléctrico de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
            Console.ReadKey();
        }
    }

    public class AutomovilGasolina : Automovil
    {
        public AutomovilGasolina(string modelo, string
                                 color, int potencia, double espacio)
            : base(modelo,
                color, potencia, espacio)
        { }
        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
                "Automóvil de gasolina de modelo: " + modelo +
                " de color: " + color + " de potencia: " +
                potencia + " de espacio: " + espacio);
            Console.ReadKey();
        }


    }

}
