using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOdj : MonoBehaviour
{
   
    void Update()
    {
        if(Timer.lifeTimer <=0)
        {
            Destroy(gameObject);
        }
    }
}
