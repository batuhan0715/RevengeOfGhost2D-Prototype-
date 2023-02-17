using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    GameObject parent;
    void Start()
    {
        parent = GameObject.Find("ParentAk");
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = parent.transform.position;
    }
}
