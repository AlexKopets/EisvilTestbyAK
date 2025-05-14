using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public ProgressBar pb1;
    public ProgressBar pb2;
    // Start is called before the first frame update
    void Start()
    {
        pb1 = obj1.GetComponent<ProgressBar>();
        pb2 = obj2.GetComponent<ProgressBar>();
       
    }

    // Update is called once per frame
    void Update()
    {
        pb1.current = Click.allCur;
        pb2.current = Click.sphereCur;
    }
}
