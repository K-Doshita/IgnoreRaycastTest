using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = 10.0f;

        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

       if(Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);
    }
}
