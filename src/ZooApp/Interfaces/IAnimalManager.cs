using ZooApp.Models;

namespace ZooApp.Interfaces
{
    interface IAnimalManager
    {
        void GetInfo(Animal animal);
        void Rename(Animal animal, string name);
        void SetPassport(Animal animal, string passport);
    }
}
