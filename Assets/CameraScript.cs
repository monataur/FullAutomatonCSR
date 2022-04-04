using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject cameraYes;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.6f;
    public Transform thetaTransform;
    public float rumbleFloat;
    public bool isRumbling;
    public int rumbleMultiplier;


    void Update()
    {
        //smoothdamping
        var smoothDampPos = Vector3.SmoothDamp(cameraYes.transform.position, thetaTransform.position, ref velocity, smoothTime);
        //if you want to change camera stuff, do it here
        cameraYes.transform.position = new Vector3(smoothDampPos.x, smoothDampPos.y, -10f);
    }
}
