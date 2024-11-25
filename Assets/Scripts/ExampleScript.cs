using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ExampleScript : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 0.1f;
    // Start is called before the first frame update

    private GameObject extraObject = null;
    void Start()
    {
        extraObject = GameObject.FindGameObjectWithTag("RotatingCube");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += transform.right * rotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        extraObject.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));

       // Debug.Log("Current rotation: " + transform.rotation.eulerAngles.y);

    }
}
