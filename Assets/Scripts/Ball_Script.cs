using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_Script : MonoBehaviour
{
    public Text winText;
    public Plateau_script Plateau;
    public GameObject Ball;
    private Vector3 posInitBall; 
    // Start is called before the first frame update
    

    void Start()
    {
       posInitBall = transform.position;
       //Debug.Log(posInitBall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider collider)
    {
        if(collider.CompareTag("Zone")) {
            Ball.transform.position = posInitBall;
            Plateau.ResetPosition();
        }

        if(collider.CompareTag("Arrivee")) 
        {
           Destroy(Ball);
           Plateau.ResetPosition();
           Text txt = winText.GetComponent<Text>();
           txt.text = "Bravo !";
        }
    }
}
