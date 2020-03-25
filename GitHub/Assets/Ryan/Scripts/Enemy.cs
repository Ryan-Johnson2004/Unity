using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemy;
    public float angle;
    public float range;
    private float currAngle = 0;

    private void OnDrawGizmos()
    {
        Vector3 dir = new Vector3(Mathf.Cos(currAngle * Mathf.Deg2Rad)*range,0 , Mathf.Sin(currAngle * Mathf.Deg2Rad)*range);
        Gizmos.DrawLine(enemy.position, enemy.position+ dir );
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 dir = new Vector3(Mathf.Cos(currAngle * Mathf.Deg2Rad)*range, 0, Mathf.Sin(currAngle * Mathf.Deg2Rad)*range);
        if (Physics.Linecast(enemy.position,enemy.position+dir)) 
        {
            
        }
        currAngle = Mathf.MoveTowards(currAngle, angle, 1f);
        if(currAngle == angle)
        {
            angle = -angle;
        }
        
    }
}
