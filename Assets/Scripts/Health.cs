using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Health : MonoBehaviour
{
    public UnityEvent OnHealthExpired;
    
    private float _HealthPoints = 100f;

    public float HealthPoints
    {
        get { return _HealthPoints; }
        set
        {
            _HealthPoints = value;

            if (_HealthPoints <= 0)
            {
                OnHealthExpired.Invoke();
            }
        }
    }
    
}