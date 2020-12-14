using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;
    public AudioSource tickSource;
    

    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = teleportTarget.transform.position;
        tickSource.Play();
        
    }

    
}
