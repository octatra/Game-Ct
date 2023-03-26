using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public List<Transform> TargetPoint;
    public float Speed;
    public int target;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPoint[target].position, Speed * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        if (transform.position == TargetPoint[target].position)
        {
            if (target == TargetPoint.Count - 1)
            {
                target = 0;
                transform.localScale = new Vector3(-7, 7, 7);
            }
            else
            {
                target += 1;
                transform.localScale = new Vector3(7, 7, 7);
            }
        }
    }

}
