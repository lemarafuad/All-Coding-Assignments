using UnityEngine;

public class MethodChainingExample : MonoBehaviour
{
    class ControllObject
    {
        GameObject gameObject;
        public ControllObject(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
        public ControllObject SetPosition(Vector3 position)
        {
            gameObject.transform.position = position;
            return this;
        }
        public ControllObject SetRotation(Vector3 rotation)
        {
            gameObject.transform.rotation = Quaternion.Euler(rotation);
            return this;
        }
        public ControllObject SetScale(Vector3 scale)
        {
            gameObject.transform.localScale = scale;
            return this;
        }

    }
    void Start()
    {
        GameObject gameObject = GameObject.Find("Part7GameObject");
        if (gameObject)
        {
            ControllObject controllObject = new ControllObject(gameObject);
            controllObject.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
        }
    }
    void Update()
    {

    }
}
