using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField]
    private int _countObjectsToFall = 3;
    
    [SerializeField]
    private Shelf _shelf;
    
    private int _countSpawnObjects;

    private void Awake()
    {
        _shelf.ItemSpawned += OnItemSpawned;
    }

    private void OnDestroy()
    {
        _shelf.ItemSpawned -= OnItemSpawned;
    }

    private void OnItemSpawned()
    {
        _countSpawnObjects++;

        if (_countSpawnObjects >= _countObjectsToFall)
        {
            _shelf.Fall();
        }
    }

    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}