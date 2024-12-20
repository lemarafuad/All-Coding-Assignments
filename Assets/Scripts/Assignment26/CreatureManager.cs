using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Kangaroo Kangaroo = new Kangaroo();
            Duck duck = new Duck();
            List<Creature> creatures = new List<Creature>
            {
                Kangaroo,duck
            };
            IRunnable[] runnables = new IRunnable[] { new Kangaroo(), new Duck() };
            IJumpable[] jumpables = new IJumpable[] { new Kangaroo() };
            ISwimmable[] swimmables = new ISwimmable[] { new Duck() };


            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }
    }
}