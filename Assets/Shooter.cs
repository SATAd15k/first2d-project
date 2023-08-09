// aka Gun

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject FireballPrefab;
    public Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // grabs the camera with the tag main; you can make other cameras and add tags
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Sees where the mouse is relavtive to a place withing the world

            mousePosition.z = transform.position.z; // anchors mouse z axis aka flattening / limiting to x and y plane only

            // The direction from A to B == A - B (getting direction from 2 positions)
            Vector3 directToMouse = mousePosition - transform.position;
            float angle = Mathf.Atan2(directToMouse.y, directToMouse.x) * Mathf.Rad2Deg; // Measured in radiants

            Quaternion bulletRotationTowardsMouse = Quaternion.Euler(0, 0, angle); // Euler pronounced oiler
            

            Instantiate(FireballPrefab, transform.position + (Vector3) offset, bulletRotationTowardsMouse);
        }
        
    }
}
