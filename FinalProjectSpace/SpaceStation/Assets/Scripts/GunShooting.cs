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

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()  //store position of gun to allow pickup after colliding with enemy
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }
    
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && ovrGrabbable.isGrabbed) // Maybe chance to float for smaller trigger press using float  //https://developer.oculus.com/documentation/unity/unity-ovrinput/#unity-ovrinput-touch
        {
            Shoot();
        }
    }

    void Shoot()  //https://stackoverflow.com/questions/23538680/bullet-prefab-script
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);  
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
    }

    public void ResetGunPosition()  //set position of gun to spawn
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }
}
