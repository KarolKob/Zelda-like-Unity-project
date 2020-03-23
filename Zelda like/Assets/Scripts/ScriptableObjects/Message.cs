using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Message : ScriptableObject
{
    public List<MessageListener> listeners = new List<MessageListener>();

    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(MessageListener listener)
    {
        listeners.Add(listener);
    }

    public void DeRegisterListener(MessageListener listener)
    {
        listeners.Remove(listener);
    }
}
