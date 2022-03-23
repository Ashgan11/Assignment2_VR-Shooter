using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private float speed, damage;
    private CapsuleCollider collisionCapsule;
    private Vector3 direction;
    // Start is called before the first frame update
    public void Initialize(float speed, Vector3 direction, float damage) {
        this.speed = speed;
        this.direction = direction.normalized;
        this.damage = damage;        
        collisionCapsule = this.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(){
        Debug.Log("Collision!");
        Destroy(this.gameObject);
    }
}