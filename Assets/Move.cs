using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Move : MonoBehaviour
{
    public Rigidbody player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.isKinematic = true;
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right*0.05f;

        }if (Input.GetKey("a"))
        {
            transform.position += Vector3.left*0.05f;

        }if (Input.GetKey("w"))
        {
            player.isKinematic = false;
            transform.position += Vector3.up*.35f;

        }if (Input.GetKey("s"))
        {
            player.isKinematic = false;
            transform.position += Vector3.down*0.35f;

        }
    }
}
