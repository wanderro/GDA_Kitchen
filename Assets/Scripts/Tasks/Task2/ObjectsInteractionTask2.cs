using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField]
    private GameObject _lampPrefab;

    [SerializeField] 
    private Transform _parentRoot;
    
    private void Awake()
    {
        Instantiate(_lampPrefab, _parentRoot);
    }
}