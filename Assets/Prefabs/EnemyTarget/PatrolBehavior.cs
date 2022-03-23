using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : MonoBehaviour
{
    public GameObject target;
    private Vector3 targetPosition, origPosition, patrolPosition;
    public float smoothTime = 0.5f;
    public float speed = 10;
    public float tolerance = 0.1f;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        patrolPosition = targetPosition = target.transform.position;
        origPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
        if (Vector3.Distance(transform.position, targetPosition)<= tolerance) switchTarget();
    }

    void switchTarget(){
        if (targetPosition == patrolPosition) {
            targetPosition = origPosition;
        }
        else targetPosition = patrolPosition;
    }
}