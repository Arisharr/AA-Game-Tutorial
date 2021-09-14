using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject PinPrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootPin();
        }
    }

    public void ShootPin()
    {
        Instantiate(PinPrefab, transform.position, transform.rotation);
    }
}
