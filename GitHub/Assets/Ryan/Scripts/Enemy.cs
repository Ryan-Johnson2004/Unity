using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemy;
    public float angle;
    public float range;
    private float currAngle = 0;
    public Light lightHandler;
    
    private void OnDrawGizmos()
    {
        Vector3 dir = new Vector3(Mathf.Cos(currAngle * Mathf.Deg2Rad)*range,0 , Mathf.Sin(currAngle * Mathf.Deg2Rad)*range);
        Gizmos.DrawLine(enemy.position, this.transform.position+ dir );
        
    }


    void Start()
    {
       
    }

    
    void Update()
    {
        

        Vector3 dir = new Vector3(Mathf.Cos(currAngle * Mathf.Deg2Rad)*range, 0, Mathf.Sin(currAngle * Mathf.Deg2Rad)*range);
        if (Physics.Linecast(this.transform.position,this.transform.position+dir)) 
        {
            
        }
        currAngle = Mathf.MoveTowards(currAngle, angle, Time.deltaTime*30f);
        if(currAngle == angle)
        {
            angle = -angle;
        }
        lightHandler.transform.LookAt(enemy.position + dir);
        



    }
}
