using System;
namespace Laboratorio2DiseñoDominioSolid
{
    public interface IAthlete
    {
        double Speed { get; set; }
        double Height { get; set; }
        void RegisterDataAthlete();
        void ShowDataAthlete();
    }
}
