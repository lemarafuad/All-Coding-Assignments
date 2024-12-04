using UnityEngine;
using UnityEngine.Rendering;

namespace Assignment24
{
    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState = new RaceState();
        Vector3 startPosition = new Vector3(8.88f, 0, 0);
        Vector3 acceleratPosition1 = new Vector3(5f, 0, 0);
        Vector3 acceleratPosition2 = new Vector3(-16.5f, 0, -3f);
        Vector3 turnPosition = new Vector3(-15f, 0, 0);
        Vector3 intermediatePosition = new Vector3(-16.5f, 0, 0);
        Vector3 targetPosition = new Vector3(-16.5f, 0, -29f);
        Vector3 direction;
        float currentSpeed = 0f;
        float acceleration = 1f;
        bool reachedInFirst = false;

        void SimulateRace()
        {
            switch (raceState)
            {
                case RaceState.Start:

                    Debug.Log("The race is about to begin. Get ready!");
                    break;

                case RaceState.Accelerate:

                    Debug.Log("You press the gas pedal. The car speeds up!");
                    break;

                case RaceState.Turn:

                    Debug.Log("You approach a sharp turn. Be careful not to crash!");
                    break;

                case RaceState.Crash:

                    Debug.Log("You hit a barrier. The race is over.");
                    break;

                case RaceState.Finish:

                    Debug.Log("You crossed the finish line. Well done!");
                    break;

                default:

                    Debug.Log("This state is not defined. Something is wrong.");
                    break;

            }
        }

        void MoveTheRacer()
        {
            float deltaTime = Time.deltaTime;

            if (!reachedInFirst)
            {
                direction = intermediatePosition - transform.localPosition;
                currentSpeed += acceleration * deltaTime;
                transform.localPosition += direction.normalized * currentSpeed * deltaTime;

                if (Vector3.Distance(transform.localPosition, startPosition) < 0.1f)
                {
                    raceState = RaceState.Start;
                }
                else if (Vector3.Distance(transform.localPosition, acceleratPosition1) < 0.1f)
                {
                    raceState = RaceState.Accelerate;
                }
                else if (Vector3.Distance(transform.localPosition, turnPosition) < 0.1f)
                {
                    raceState = RaceState.Turn;
                }
                else if (Vector3.Distance(transform.localPosition, turnPosition) < 0.1f)
                {
                    raceState = RaceState.Turn;
                }
                else if (Vector3.Distance(transform.localPosition, intermediatePosition) < 0.1f)
                {
                    reachedInFirst = true;
                    currentSpeed = 0;
                }

            }
            else
            {
                direction = targetPosition - transform.localPosition;
                currentSpeed += acceleration * deltaTime;
                transform.localPosition += direction.normalized * currentSpeed * deltaTime;

                if (Vector3.Distance(transform.localPosition, acceleratPosition2) < 0.1f)
                {
                    raceState = RaceState.Accelerate;
                }
                else if (Vector3.Distance(transform.localPosition, targetPosition) < 0.1f)
                {
                    raceState = RaceState.Finish;
                }
            }
        }
        void Start()
        {
            Debug.Log(transform.localPosition);

        }
        void Update()
        {
            MoveTheRacer();
            SimulateRace();
        }
    }
}