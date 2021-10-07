using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.009f;
    private Animator PlayerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = new GameObject();
        PlayerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(-speed, 0.0f, 0.0f);
            PlayerAnimation.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(speed, 0.0f, 0.0f);
            PlayerAnimation.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(0.0f, 0.0f, speed);
            PlayerAnimation.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(0.0f, 0.0f, -speed);
            PlayerAnimation.SetBool("isWalking", true);
        }
       // PlayerAnimation.SetBool("isWalking", false);
    }
}
