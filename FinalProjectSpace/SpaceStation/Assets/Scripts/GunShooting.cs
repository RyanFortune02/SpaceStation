using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=bqNW08Tac0Y  possibly useful if switched to raycast approach
public class GunShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  //Store prefab in inspector
    public Transform bulletSpawn;  //to shoot bullet from barrel of gun instead of from center
    public float bulletSpeed = 1000f;  //Making bullet fast to appear life like
    public OVRGrabbable ovrGrabbable;

    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && ovrGrabbable.isGrabbed)// Maybe chance to float for smaller trigger press  //https://developer.oculus.com/documentation/unity/unity-ovrinput/#unity-ovrinput-touch
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
    }
}
