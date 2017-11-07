using SDG.Unturned;
using UnityEngine;

namespace ApokPT.RocketPlugins
{
    class Destructible
    {
        public Destructible(Transform transform, ElementType type, InteractableVehicle vehicle = null, Zombie zombie = null, Animal animal = null)
        {
            Transform = transform;
            Type = type;
            Vehicle = vehicle;
            Zombie = zombie;
            Animal = animal;
        }

        public Animal Animal { get; private set; }
        public Zombie Zombie { get; private set; }
        public InteractableVehicle Vehicle { get; private set; }
        public Transform Transform { get; private set; }
        public ElementType Type { get; private set; }
    }
}
