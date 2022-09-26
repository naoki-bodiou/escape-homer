using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthPoints = 3;

    void Start()
    {
        Debug.Log("TEST");
    }

    void Update()
    {

        if (healthPoints == 0)
        {
            Debug.Log("TEST");
        }
    }
}
