using UnityEngine;

namespace Part2
{
    public class TestCustomObject : MonoBehaviour
    {
        CustomObject customObject0 = new CustomObject(1, "Lemara");
        CustomObject customObject1 = new CustomObject(1, "Lemara");
        CustomObject customObject2 = new CustomObject(2, "Rozan");
        void Start()
        {
            print(customObject0);
            print(customObject1);
            print(customObject2);

            if (customObject0 == customObject1)
            {
                Debug.Log("customObject0 and customObject1 have the same data.");
            }
            if (customObject0 != customObject1)
            {
                Debug.Log("customObject0 and customObject1 have different data.");
            }

            if (customObject1 == customObject2)
            {
                Debug.Log("customObject1 and customObject2 have the same data.");
            }
            if (customObject1 != customObject2)
            {
                Debug.Log("customObject1 and customObject2 have different data.");
            }
        }
    }
}