using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 6;
    int MaxDist = 10;
    int MinDist = 0;
    public GameManager gameManager;
    public AudioSource tickSource;



    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            transform.LookAt(Player);
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {

                }

            }

        }





    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {

            tickSource.Play();

        }
    }
}
