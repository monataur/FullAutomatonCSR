using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    public Transform thetaTransform;
    public Rigidbody2D rb;
    public bool isDashing;
    public Transform pointerThing;
    public GameObject detectionCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LookAt 2D
        // get the angle
        Vector3 norTar = (thetaTransform.position - transform.position).normalized;
        float angle = Mathf.Atan2(norTar.y, norTar.x) * Mathf.Rad2Deg;
        // rotate to angle
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle + 90);
        transform.rotation = rotation;

        void OnCollisionEnter (Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {

            }
        }
    }
}
