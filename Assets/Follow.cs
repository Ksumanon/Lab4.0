using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform GameObject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(GameObject);
    }
}