using System;
using System.Collections.Generic;

namespace Laboratorio2DiseñoDominioSolid
{
    public class SoccerChampionship:Championship
    {
        protected override string Name { get; set; }
        protected override IList<SoccerTeam> Teams { get; set; }

        public SoccerChampionship()
        {
            Teams = new List<SoccerTeam>();
            SoccerTeam soccerTeam = new SoccerTeam();
            soccerTeam.TeamName = "Real Madrid";
            soccerTeam.Coach = "Zidane";
            soccerTeam.President = "Florentino";
            Teams.Add(soccerTeam);
            
        }

        public override void RegisterData()
        {
            Console.WriteLine("Ingrese Nombre del Campeonato");
            Name = Console.ReadLine();
        }

        public override void RegisterTeam(SoccerTeam team)
        {
            Teams.Add(team);
        }

        public override void ShowData()
        {
            Console.WriteLine("Nombre del Campeonato: " + Name);
            Console.WriteLine("-------Lista de Equipos--------");
        }
        public void ShowTeams()
        {
            foreach (var team in Teams)
            {
                team.ShowData();
            }
        }
        public SoccerTeam FindTeam(string name)
        {
            foreach(var team in Teams)
            {
                if (team.TeamName == name)
                    return team;
            }
            return null;
        }
        public void AddTeam()
        {
            SoccerTeam soccerTeam = new SoccerTeam();
            soccerTeam.RegisterData();
            Teams.Add(soccerTeam);
        }
        public void ShowPlayersToTeam()
        {
            string Nombre;
            Console.WriteLine("Ingrese el Nombre del equipo");
            Nombre = Console.ReadLine();
            Console.WriteLine("----------Lista de Jugadores------");
            var team = FindTeam(Nombre);
            if (team != null)
                team.ShowSoccerPlayes();
            else
                Console.WriteLine("No existe el equipo ingresado, intente de nuevo");
        }
        public void AddPlayerToTeam()
        {
            string Nombre;
            Console.WriteLine("Ingrese el Nombre del equipo");
            Nombre = Console.ReadLine();
            Console.WriteLine("----------Lista de Jugadores------");
            var team = FindTeam(Nombre);
            if (team != null)
            {
                SoccerPlayer soccerPlayer = new SoccerPlayer();
                soccerPlayer.RegisterDataSoccerPlayer();
                team.Fichar(soccerPlayer);
            }
            else
                Console.WriteLine("No existe el equipo ingresado, intente de nuevo");
        }
        public void Menu()
        {

            int Opcion;
            do
            {
                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Añadir equipo");
                Console.WriteLine("2. Mostrar Equipos");
                Console.WriteLine("3. Mostrar Jugadores de un equipo");
                Console.WriteLine("4. Añadir Jugador a un equipo");
                Console.WriteLine("0. Salir");
                Opcion = Convert.ToInt16(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        AddTeam();
                        break;
                    case 2:
                        ShowTeams();
                        break;
                    case 3:
                        ShowPlayersToTeam();
                        break;
                    case 4:
                        AddPlayerToTeam();
                        break;
                    default:
                        break;
                }
            } while (Opcion != 0);
        }
    }
}
