using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau_script : MonoBehaviour
{

    public float speed = 20;
    public GameObject Plato;
    public float xAngle, yAngle, zAngle;

    // Start is called before the first frame update
    void Start()
    {
        xAngle = 0.0f;
        yAngle = 0.0f;
        zAngle = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed);
    }

    public void ResetPosition() 
    {
        Plato.transform.rotation = Quaternion.identity;
   
    }

}
