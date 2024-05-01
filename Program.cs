using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class SuperHeroe
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        //public string[] SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder superPoder { get; set; } = new SuperPoder();


    }

    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public int Nivel;
    }

    enum NivelPoder
    {
        NoAplica
      , NivelUno
      , NivelDos
      , NivelTres
      , NivelCuatro
      , NivelCinco
      , NivelSeis
      , NivelSiete
      , NivelOcho
      , NivelNueve
    }


    class Program
    {
        static void Main(string[] args)
        {

            var superman = new SuperHeroe();
            superman.Id = 1;
            superman.Nombre = "Superman";
            superman.IdentidadSecreta = "Clark Kent";
            superman.Ciudad = "Metropolis";
            superman.PuedeVolar = true;

            superman.superPoder.Nombre = "Super Fuerza";
            superman.superPoder.Descripcion = "Capacidad de volar, visión láser y telequinesis";
            superman.superPoder.Nivel = (int)NivelPoder.NivelNueve;



            var BatMan = new SuperHeroe();
            BatMan.Id = 2;
            BatMan.Nombre = "Batman";
            BatMan.IdentidadSecreta = "Bruce Wayne";
            BatMan.Ciudad = "Gotica";
            BatMan.PuedeVolar = false;

            BatMan.superPoder.Nombre = "Inteligencia";
            BatMan.superPoder.Descripcion = "Recurre a su intelecto,habilidades de detective y fuerza fisica";
            BatMan.superPoder.Nivel = (int)NivelPoder.NivelSeis;


            var Raven = new SuperHeroe();
            Raven.Id = 1;
            Raven.Nombre = "Raven";
            Raven.IdentidadSecreta = "Rachel Roth";
            Raven.Ciudad = "Azarath";
            Raven.PuedeVolar = true;

            Raven.superPoder.Nombre = "Hechicera";
            Raven.superPoder.Descripcion = "Puede mover objetos con su mente, volar, abrir portales y crear campos de fuerza ";
            Raven.superPoder.Nivel = (int)NivelPoder.NivelNueve;

            Console.WriteLine("Nombre:" + superman.Nombre);
            Console.WriteLine("Identidad Secreta :" + superman.IdentidadSecreta);
            Console.WriteLine("Ciudad:" + superman.Ciudad);
            Console.WriteLine("Puede volar :" + superman.PuedeVolar);
            Console.WriteLine("Descripcion:" + superman.superPoder.Descripcion);
            Console.WriteLine("Nivel:" + superman.superPoder.Nivel);

            Console.WriteLine("Nombre:" + BatMan.Nombre);
            Console.WriteLine("Identidad Secreta :" + BatMan.IdentidadSecreta);
            Console.WriteLine("Ciudad:" + BatMan.Ciudad);
            Console.WriteLine("Puede volar :" + BatMan.PuedeVolar);
            Console.WriteLine("Descripcion:" + BatMan.superPoder.Descripcion);
            Console.WriteLine("Nivel:" + BatMan.superPoder.Nivel);

            Console.WriteLine("Nombre:" + Raven.Nombre);
            Console.WriteLine("Identidad Secreta :" + Raven.IdentidadSecreta);
            Console.WriteLine("Ciudad:" + Raven.Ciudad);
            Console.WriteLine("Puede volar :" + Raven.PuedeVolar);
            Console.WriteLine("Descripcion:" + Raven.superPoder.Descripcion);
            Console.WriteLine("Nivel:" + Raven.superPoder.Nivel);


        }
    }
}