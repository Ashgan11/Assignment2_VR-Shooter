using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private float speed, damage;
    public float timeToLive = 30;
    private float timeAlive = 0;
    private CapsuleCollider collisionCapsule;    
    // Start is called before the first frame update
    public void Initialize(float speed, float damage) {
        this.speed = speed;
        this.damage = damage;        
        collisionCapsule = this.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Bullet decay time
        timeAlive += Time.deltaTime;
        if (timeAlive >= timeToLive) Destroy(gameObject);
    }

    void OnCollisionEnter(){
        Debug.Log("Collision!");
        Destroy(this.gameObject);
    }
}