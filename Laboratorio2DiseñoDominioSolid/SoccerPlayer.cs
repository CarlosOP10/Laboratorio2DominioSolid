using System;
namespace Laboratorio2DiseñoDominioSolid
{
    public class SoccerPlayer:IPlayer,IAthlete
    {
        public SoccerPlayer()
        {
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Speed { get; set; }
        public double Height { get; set; }
        public int Dorsal { get; set; }
        public void Train()
        {
            Console.WriteLine("Estoy entrenando!!!");
        }

        public void PlayMatch()
        {
            Console.WriteLine("Jugando un partido");
        }
        public void RegisterDataPlayer()
        {
            Console.Write("Ingrese su nombre: ");
            Name=Console.ReadLine();
            Console.Write("Ingrese su Edad: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese su numero de Dorsal: ");
            Dorsal = Convert.ToInt16(Console.ReadLine());
        }

        public void RegisterDataAthlete()
        {
            Console.Write("Ingrese la velocidad del jugador: ");
            Speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la Altura: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void RegisterDataSoccerPlayer()
        {
            RegisterDataPlayer();
            RegisterDataAthlete();
        }
        public void ShowDataPlayer()
        {
            Console.WriteLine("      Nombre: "+ Name);
            Console.WriteLine("      Edad: "+ Age);
            Console.WriteLine("      Dorsal: "+ Dorsal);
        }

        public void ShowDataAthlete()
        {
            Console.WriteLine("      Velocidad: "+Speed+"Km/h");
            Console.WriteLine("      Altura: "+Height+"m");
        }
        public void ShowDataSoccerPlayer()
        {
            Console.WriteLine("----------Datos del jugador----------");
            ShowDataPlayer();
            ShowDataAthlete();
        }
    }
}
