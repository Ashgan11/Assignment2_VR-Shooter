using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPosition;
    public float speed = 10, damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Bullet spawn!");
            GameObject newBullet;
            newBullet = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);
            newBullet.GetComponent<ProjectileScript>().Initialize(speed, this.gameObject.transform.forward, damage);            
        }
    }
}
