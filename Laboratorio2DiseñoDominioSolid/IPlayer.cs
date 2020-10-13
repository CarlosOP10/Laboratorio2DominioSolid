using System;
namespace Laboratorio2DiseñoDominioSolid
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Age { get; set; }
        void Train();
        void PlayMatch();
        void RegisterDataPlayer();
        void ShowDataPlayer();
    }
}
