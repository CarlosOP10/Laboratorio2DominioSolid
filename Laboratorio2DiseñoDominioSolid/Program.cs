using System;

namespace Laboratorio2DiseñoDominioSolid
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SoccerChampionship soccerChampionship = new SoccerChampionship();
            soccerChampionship.RegisterData();
            soccerChampionship.Menu();
            
        }
    }
}
