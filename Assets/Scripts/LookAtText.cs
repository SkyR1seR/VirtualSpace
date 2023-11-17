using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtText : MonoBehaviour
{
    Transform head;
    // Start is called before the first frame update
    void Start()
    {
        head = FindAnyObjectByType<AudioListener>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(head.position);
    }
}
