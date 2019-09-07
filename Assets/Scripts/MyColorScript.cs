using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * By Charl Cronje - webAlly
 * 
 * Test Project to Change the Color (Hide and Show) a Plane on Canvas
 * Youtube Reference: https://www.youtube.com/watch?v=7K2SMZQRKnw 
 */

public class MyColorScript : MonoBehaviour
{
    public GameObject plane;

    // Serialized Fields will display in the inspector but will not be editable
    [SerializeField]
    private MeshRenderer myRenderer;

    public void Start()
    {
        Debug.Log("We made it here");
    }

    public void OnClickChangeColor()
    {
        myRenderer = plane.GetComponent<MeshRenderer>();
        myRenderer.enabled = !myRenderer.enabled;
    }
}
