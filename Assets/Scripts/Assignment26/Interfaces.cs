using UnityEngine;

namespace Assignment26
{

    public interface IRunnable
    {
        public void Run();
    }

    public interface IJumpable
    {
        public void Jump();
    }

    public interface ISwimmable
    {
        public void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

    }

    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

    }
}
