using System;
namespace Laboratorio2DiseñoDominioSolid
{
    public class SoccerTeam:Team
    {
        public string Coach { get; set; }
        public string President { get; set; }
        public SoccerTeam()
        {
            Coach = "";
            President = "";
        }
        public override void RegisterData()
        {
            Console.Write("Ingrese el nombre del equipo: ");
            TeamName=Console.ReadLine();
            Console.Write("Ingrese el nombre del Entrenador: ");
            Coach = Console.ReadLine();
            Console.Write("Ingrese el nombre del Presidente: ");
            President = Console.ReadLine();

        }
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Entrenador: " + Coach);
            Console.WriteLine("Presidente: " + President);
            
            
        }
        public override void RegisterPlayers()
        {
            SoccerPlayer soccerPlayer = new SoccerPlayer();
            Console.Clear();
            Console.WriteLine("Ingrese los datos del nuevo jugador");
            soccerPlayer.RegisterDataSoccerPlayer();
            players.Add(soccerPlayer);
        }
        public override void Fichar(SoccerPlayer soccerPlayer)
        {
            players.Add(soccerPlayer);
        }
        public void ShowSoccerPlayes()
        {
            
            foreach (var player in players)
            {
                player.ShowDataSoccerPlayer();
            }
        }
    }
}
