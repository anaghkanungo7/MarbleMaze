using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotFollow : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;

    void Start()
    {
                print("Initial pivot position!!");
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        print("Updating pivot position!!");
        transform.position = target.transform.position;
    }
}
