using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Carwash
{
    public class CarwashModel
    {
        private CarWashDelegate Del;
        public CarwashModel() 
        {
            Del = Preparer;
            Del += delegate (Voiture v) { Console.WriteLine($"je lave la voiture : {v.Plaque} "); };
            Del += (Voiture v) => { Console.WriteLine($"je sèche la voiture : {v.Plaque} "); };
            Del += (Voiture v) => Console.WriteLine($"je finalise la voiture : {v.Plaque} ");
        }
        private void Preparer(Voiture v)
        {
            Console.WriteLine($"je prépare la voiture : {v.Plaque} ");
        }

        //private void Laver(Voiture v)
        //{
        //    Console.WriteLine($"je lave la voiture : {v.Plaque} ");
        //}

        //private void Secher(Voiture v)
        //{
        //    Console.WriteLine($"je sèche la voiture : {v.Plaque} ");
        //}

        //private void Finaliser(Voiture v)
        //{
        //    Console.WriteLine($"je finalise la voiture : {v.Plaque} ");
        //}
        public void Traiter(Voiture v)
        {
            Del(v);
        }
    }
}
