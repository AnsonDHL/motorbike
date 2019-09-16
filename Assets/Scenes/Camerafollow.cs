using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour

{
    public Transform target;
    Vector3 carmera;

    // Start is called before the first frame update
    void Start()
    {
        carmera = target.position;
        carmera.z = -10;
    }

    // Update is called once per frame
    void Update()
    {
        carmera = target.position;
        carmera.z = -10;
        transform.position = carmera;
    }
}
