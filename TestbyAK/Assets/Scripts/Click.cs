using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public static int sphereCur = 0;
    public static int allCur = 0;
    private void OnMouseDown()
    {
        Destroy(gameObject);
        allCur++;
        
        if (gameObject.tag == "Sphere") 
        {
            sphereCur++;

        }

    }
}
