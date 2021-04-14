using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject door2;
    bool isDooropen;
    public float speed;

    public void OpenDoor()
    {
        Destroy(door);
        Destroy(door2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isDooropen)
        {
            OpenDoor();
            isDooropen = true;
            this.gameObject.SetActive(false);
        }
    }

}
