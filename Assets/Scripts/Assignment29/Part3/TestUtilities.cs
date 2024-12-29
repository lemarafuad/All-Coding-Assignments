using UnityEngine;

namespace Part3
{
    public class TestUtilities : MonoBehaviour
    {
        void Start()
        {
            Utilities.Add(new[] { 1, 2, 3, 4, 5, 6, 7 });
            Debug.Log("Lemara".RepeatString(7));
        }
    }
}