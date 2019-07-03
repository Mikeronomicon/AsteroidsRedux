using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float HealthPoints = 100f;

    private void Update()
    {
        if(HealthPoints <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
