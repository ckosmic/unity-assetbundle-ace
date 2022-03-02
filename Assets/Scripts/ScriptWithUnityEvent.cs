using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptWithUnityEvent : MonoBehaviour
{
    public UnityEvent vulnerableEvent;

    private void Start()
    {
        vulnerableEvent.Invoke();
    }
}
