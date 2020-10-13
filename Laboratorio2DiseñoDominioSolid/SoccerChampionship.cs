using System;
using System.Collections.Generic;

namespace Laboratorio2DiseñoDominioSolid
{
    public class SoccerChampionship:Championship
    {
        protected override string Name { get; set; }
        protected override IList<Team> Teams { get; set; }
        public string President { get; set; }
        public string DataInitial { get; set; }
        public string DataFinish { get; set; }

        public SoccerChampionship()
        {
            Teams = new List<Team>();
            Team soccerTeam = new SoccerTeam();
            soccerTeam.TeamName = "Real Madrid";
            soccerTeam.Coach = "Zidane";
            soccerTeam.President = "Florentino";
            Teams.Add(soccerTeam);
        }

        public override void RegisterData()
        {
            Console.Write("Ingrese Nombre del Campeonato: ");
            Name = Console.ReadLine();
            Console.Write("Ingrese Nombre del Presidente: ");
            President = Console.ReadLine();
            Console.Write("Ingrese la fecha de inicio: ");
            DataInitial = Console.ReadLine();
            Console.Write("Ingrese la fecha de fin: ");
            DataFinish = Console.ReadLine();
        }

        public override void RegisterTeam(SoccerTeam team)
        {
            Teams.Add(team);
        }

        public override void ShowData()
        {
            Console.WriteLine("----Datos del Campeonato----");
            Console.WriteLine("Nombre del Campeonato: " + Name);
            Console.WriteLine("Nombre del Presidente: " + President);
            Console.WriteLine("Fecha Inicio: " + DataInitial);
            Console.WriteLine("Fecha Final: " + DataFinish);

        }
        public void ShowTeams()
        {
            foreach (var team in Teams)
            {
                team.ShowData();
            }
        }
        public Team FindTeam(string name)
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
            Team soccerTeam = new SoccerTeam();
            soccerTeam.RegisterData();
            Teams.Add(soccerTeam);
        }
        public void ShowPlayersToTeam()
        {
            string Nombre;
            Console.Write("Ingrese el Nombre del equipo: ");
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
            Console.Write("Ingrese el Nombre del equipo: ");
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
                Console.WriteLine("1. Mostrar Datos del Campeonato");
                Console.WriteLine("2. Añadir equipo");
                Console.WriteLine("3. Mostrar Equipos");
                Console.WriteLine("4. Mostrar Jugadores de un equipo");
                Console.WriteLine("5. Añadir Jugador a un equipo");
                Console.WriteLine("0. Salir");
                Opcion = Convert.ToInt16(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        ShowData();
                        break;
                    case 2:
                        AddTeam();
                        break;
                    case 3:
                        ShowTeams();
                        break;
                    case 4:
                        ShowPlayersToTeam();
                        break;
                    case 5:
                        AddPlayerToTeam();
                        break;
                    default:
                        break;
                }
            } while (Opcion != 0);
        }
    }
}
