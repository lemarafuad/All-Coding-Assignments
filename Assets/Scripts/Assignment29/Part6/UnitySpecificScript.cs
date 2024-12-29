using UnityEngine;

namespace Part6
{
    public class UnitySpecificScript : MonoBehaviour
    {
        new GameObject gameObject;
        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }
        void Start()
        {
            print("Game started!");
            // Home made functions hhhhhh :)
            FindObjectByName("TargetObject");
            FindObjectByTag("Joker");
            FindLight();

        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {
                gameObject = GameObject.Find("TargetObject");
                if (gameObject)
                {
                    gameObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
                else print("TargetObject is alredy deactivated!");

            }
        }

        void FindObjectByName(string name)
        {
            gameObject = GameObject.Find(name);
            string msg = gameObject ? gameObject.name : $"No {name} found";
            print(msg);
        }
        void FindObjectByTag(string tag)
        {
            gameObject = GameObject.FindGameObjectWithTag(tag);
            string msg = gameObject ? gameObject.name : $"No {tag} found";
            print(msg);
        }

        void FindLight()
        {
            Light lightObject = GameObject.FindObjectOfType<Light>();
            string msg = lightObject ? lightObject.name : $"No Light Object found";
            print(msg);
        }

    }
}