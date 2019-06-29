/*
Los detalles de cada coche se proporcionan a continuación:
WagonR no es un sedan y tiene 4 asientos(seats)
HOndaCity es un sedan y tiene 4 asientos(seats)
InnovaCrysta no es un sedan y tiene 6 asientos(seats)
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Car {
    abstract class Car //esta clase no se puede instanciar
    {
        protected bool isSedan; //solamente las clases hijas pueden acceder
        protected String seats; //solamente las clases hijas pueden acceder
        public Car(){}
        public Car (Boolean isSedan, string seats) //esto es un metodo de acceso para las variables publicas de contructor
        {
            this.isSedan = isSedan;
            this.seats = seats;
        }
        public bool getIsSedan () {
            return this.isSedan;
        }
        public string getSeats () {
            return this.seats;
        }
        public abstract string getMileage ();
        public void printCar (string name) {
            Console.WriteLine ("A {0} is{1} Sedan, is {2}-seater, and has a mileage of around {3}.",
                name,
                this.getIsSedan () ? "" : " not",
                this.getSeats (),
                this.getMileage ());
        }
    }

    // Write your code here.
    class WagonR : Car //clase WagonR que hereda de car
    {
        
        private string mileage;
        public WagonR (int kmpl) //metodo contructor obligatoriamente el mismo nombre de la clase..No retorn ni void
        {

            this.isSedan = false;
            this.seats = "4";
            this.mileage = Convert.ToString(kmpl) + " kmpl";
        }
        public override String getMileage () {
            return mileage;
        }

    }


    //HondaCity class
    class HondaCity : Car
    {
        private string mileage;
        public HondaCity (int kmpl) //metodo contructor obligatoriamente el mismo nombre de la clase..No retorn ni void
        {

            this.isSedan = true;
            this.seats = "4";
            this.mileage = Convert.ToString(kmpl) + " kmpl";
        }
        public override String getMileage () {
            return mileage;
        }
    }


    //InnovaCrysta class
    class InnovaCrysta : Car
    {
        private string mileage;
        public InnovaCrysta (int kmpl) //metodo contructor obligatoriamente el mismo nombre de la clase..No retorn ni void
        {

            this.isSedan = false;
            this.seats = "6";
            this.mileage = Convert.ToString(kmpl) + " kmpl";
        }
        public override String getMileage () {
            return mileage;
        }
    }

    class Solution {
        static void Main (string[] args) {
            Console.WriteLine("escribe el tipo de auto");
            Console.WriteLine("las opciones son 0, 1, 2");
            int carType = Convert.ToInt32 (Console.ReadLine ().Trim ());
            while (carType < 0 || carType > 2)
            {
                Console.WriteLine("numero equivocado");
                Console.WriteLine("el tipo de auto solamente puede ser 0, 1, 2");
                carType = Convert.ToInt32 (Console.ReadLine ().Trim ());
            }

            Console.WriteLine("escribe la cantidad de kilometros");
            Console.WriteLine("las opciones van desde 5 hasta 30");
            int carMileage = Convert.ToInt32 (Console.ReadLine ().Trim ());
            while (carMileage < 5 || carMileage > 30)
            {
                Console.WriteLine("numero equivocado");
                Console.WriteLine("las opciones van desde 5 hasta 30");
                carMileage = Convert.ToInt32 (Console.ReadLine ().Trim ());
            }

            if (carType == 0) {
                Car wagonR = new WagonR (carMileage);
                wagonR.printCar ("WagonR");

            }

             if(carType == 1){
                 Car hondaCity = new HondaCity(carMileage);
                 hondaCity.printCar("HondaCity");
             }

             if(carType == 2){
                 Car innovaCrysta = new InnovaCrysta(carMileage);
                 innovaCrysta.printCar("InnovaCrysta");
             }
        }
    }
}