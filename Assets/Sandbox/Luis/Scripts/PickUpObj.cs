using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform playerCam;
    [SerializeField] float throwForce = 10;
    bool hasPlayer = false;
    bool BeingCarried;
    private bool touched = false;
    EnemyFollow enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist < 3.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetKeyDown(KeyCode.E)) 
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            BeingCarried = true; 
            
        }
        if (BeingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                BeingCarried = false;
                touched = false;
                
            }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                BeingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                BeingCarried = false;
            }
        }
    }
    void OnTriggerEnter()
    {
        if (BeingCarried)
        {
            touched = true;
        }
    }
}
