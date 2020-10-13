using System;
using System.Collections.Generic;

namespace Laboratorio2DiseñoDominioSolid
{
    public class Team
    {
        protected string TeamName { get; set; }
        protected IList<SoccerPlayer> players;
        public Team()
        {
            TeamName = "";
            players = new List<SoccerPlayer>();
            players.Add(
                new SoccerPlayer()
                {
                    Name="Carlos",
                    Age=21,
                    Speed=28.12,
                    Dorsal=10,
                    Height=1.72
                }
            );
            players.Add(
                new SoccerPlayer()
                {
                    Name = "Fidel",
                    Age = 20,
                    Speed = 27.12,
                    Dorsal = 7,
                    Height = 1.68
                }
            );
            players.Add(
                new SoccerPlayer()
                {
                    Name = "Antonio",
                    Age = 21,
                    Speed = 29.21,
                    Dorsal = 11,
                    Height = 1.80
                }
            ); players.Add(
                 new SoccerPlayer()
                 {
                     Name = "Brandon",
                     Age = 21,
                     Speed = 28.12,
                     Dorsal = 10,
                     Height = 1.76
                 }
             );
        }

        public virtual void RegisterData(){}

        public virtual void Fichar(SoccerPlayer soccerPlayer){}

        public virtual void ShowData()
        {
            Console.WriteLine("-----DATOS DE EQUIPO----");
            Console.WriteLine("Nombre equipo: "+TeamName); 
        }

        public virtual void RegisterPlayers(){} 


    }
}
