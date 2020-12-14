using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 18;
    private Rigidbody rig;
    
    public GameManager gameManager;
     
   
    


    void Start()
    {
        rig = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

            rig.MovePosition(transform.position + movement);
            transform.rotation = Quaternion.LookRotation(movement);

        }
        




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Enemy"))
        {
            gameManager.GameOver();
            
        }

    }

}
