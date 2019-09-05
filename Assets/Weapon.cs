using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && !IsInvoking("Shoot"))
        {
            //How do we add a delay and limit the total number of prefabs?
            animator.SetBool("IsShooting", true);
            InvokeRepeating("Shoot", 0f, .5f);
        } else if(Input.GetButtonUp("Fire1")) {

            animator.SetBool("IsShooting", false);
            CancelInvoke();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
