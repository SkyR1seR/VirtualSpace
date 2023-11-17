using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    bool needReturn = false;
    // Update is called once per frame
    void Update()
    {
        if (transform.position != startPos && needReturn == false)
        {
            needReturn = true;
            StartCoroutine(startReturn());
        }
    }

    IEnumerator startReturn()
    {
        yield return new WaitForSeconds(10f);
        transform.position = startPos;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().isKinematic = false;
        needReturn = false;
    }
}
