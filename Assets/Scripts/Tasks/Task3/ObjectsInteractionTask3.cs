using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] _lamps;
    
    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
}