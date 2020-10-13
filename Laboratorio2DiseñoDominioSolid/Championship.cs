using System;
using System.Collections.Generic;

namespace Laboratorio2DiseñoDominioSolid
{
    public abstract class Championship
    {
        protected abstract string Name { get; set; }
        protected abstract IList<Team> Teams { get; set; }
        public Championship()
        {
        }
        public abstract void ShowData();
        public abstract void RegisterData();
        public abstract void RegisterTeam(SoccerTeam team);
        
    }
}
