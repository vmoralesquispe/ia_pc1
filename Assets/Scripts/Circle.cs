using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    float lose =5;
    float win =1;
    public GameObject Agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 offset = Agent.transform.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            
            if (sqrLen < win)
            {
                print("Win");
            }

            if(sqrLen < lose){
                print("Lose");
            }        
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lose);

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, win);
    }
}
