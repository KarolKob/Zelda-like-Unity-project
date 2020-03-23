using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageListener : MonoBehaviour
{
    public Message message;
    public UnityEvent messageEvent;

    public void OnSignalRaised()
    {
        messageEvent.Invoke();
    }

    private void OnEnable()
    {
        message.RegisterListener(this);
    }

    private void OnDisable()
    {
        message.DeRegisterListener(this);
    }
}
