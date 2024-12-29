using UnityEngine;

namespace Part4
{
    public class TypeManagementScript : MonoBehaviour
    {
        ICanFight[] canFights;
        void Start()
        {
            Cat cat = new Cat();
            Animal animal = cat;

            animal.MakeSound();
            animal.Move();

            cat = (Cat)animal;
            cat.MakeSound();
            cat.Move();

            canFights = new ICanFight[] { new Cat(), new Warrior() };

            foreach (ICanFight canFight in canFights)
            {
                canFight.Attack();
                // CheckTheObject(canFight); // i can call this function in other loop to match the outputs at assignment's File
            }

            foreach (ICanFight canFight in canFights)
            {
                CheckTheObject(canFight);
            }


        }
        public void CheckTheObject(ICanFight canFight)
        {
            if (canFight is Warrior)
            {
                Debug.Log("The object is Warrior");
            }
            else if (canFight is Cat)
            {
                Debug.Log("The object is Cat");
            }

        }
        public class Animal
        {
            public virtual void MakeSound()
            {
                Debug.Log("Animal sound");
            }

            public void Move()
            {
                Debug.Log("Animal moves");
            }

        }
        public class Cat : Animal, ICanFight
        {
            public override void MakeSound()
            {
                Debug.Log("Meow!");
            }
            public new void Move()
            {
                Debug.Log("Cat runs quickly");
            }
            public void Attack()
            {
                Debug.Log("Cat attacks with claws!");

            }

        }
        public interface ICanFight
        {
            public void Attack();
        }

        public class Warrior : ICanFight
        {
            public void Attack()
            {
                Debug.Log("Warrior attacks with a sword!");
            }

        }
    }

}