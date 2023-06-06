using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 rot = Camera.main.transform.eulerAngles;
        rot.z = 0;
        target.eulerAngles = rot;
    }
}
