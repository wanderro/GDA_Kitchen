using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] 
    private Toaster _toaster;

    [SerializeField]
    private Transform _waffleRoot;
    
    [SerializeField]
    private GameObject _wafflePrefab;

    private void Awake()
    {
        _toaster.TimerIsUp += OnTimerIsUp;
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        Instantiate(_wafflePrefab, _waffleRoot);
    }

}