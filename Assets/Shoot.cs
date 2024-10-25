using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform arrowLocation;
    public float shotPower;
    public AudioSource shootSound;


    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
            shootSound.Play();
        }
    }
}
