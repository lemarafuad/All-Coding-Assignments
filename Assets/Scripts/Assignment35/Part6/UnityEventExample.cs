using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    UnityEvent onEventTriggered;
    void Start()
    {
        onEventTriggered = new UnityEvent();
        onEventTriggered.AddListener(OnEventResponse);

    }

    private void OnEventResponse()
    {
        Debug.Log("The event has been triggered!");
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            onEventTriggered?.Invoke();
        }
        // onEventTriggered?.Invoke();

    }
}
