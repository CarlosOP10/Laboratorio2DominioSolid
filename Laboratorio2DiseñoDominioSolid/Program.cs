using System;

namespace Laboratorio2DiseñoDominioSolid
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Team teamSoccer = new SoccerTeam();
            //teamSoccer.RegisterData();
            teamSoccer.RegisterPlayers();
            teamSoccer.ShowData();
            
        }
    }
}
