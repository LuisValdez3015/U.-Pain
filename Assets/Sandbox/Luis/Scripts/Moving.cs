using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject door;
    bool isDooropen;
    public float speed;

    public void OpenDoor()
    {
        Destroy(door);
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
