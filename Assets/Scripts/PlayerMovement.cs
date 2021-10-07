using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.009f;
    public float rotSpeed = 0.05f;
    private Animator PlayerAnimation;
    private Vector3 playerLoc;
    private float newPlayerLoc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = new GameObject();
        PlayerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.W))
        {
             if(gameObject.transform.rotation.y==0.0f)
             {
                 gameObject.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
             }
             else if (gameObject.transform.rotation.y == 90.0f)
             {
                 gameObject.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
             }
             else if (gameObject.transform.rotation.y == 270.0f)
             {
                 gameObject.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
             }
        }
        else if (Input.GetKeyDown(KeyCode.S)) 
        {
            if (gameObject.transform.rotation.y == 180.0f)
            {
                gameObject.transform.Rotate(0, 180.0f, 0, Space.World);
            }
            else if (gameObject.transform.rotation.y == 270.0f)
            {
                gameObject.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
            }
            else if (gameObject.transform.rotation.y == 90.0f)
            {
                gameObject.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
            }
        } 
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            if (gameObject.transform.rotation.y == 90.0f)
            {
                gameObject.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
            }
            else if (gameObject.transform.rotation.y == 180.0f)
            {
                gameObject.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
            }
            else if (gameObject.transform.rotation.y == 0.0f)
            {
                gameObject.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
            }
        } 
        else if (Input.GetKeyDown(KeyCode.A)) 
        {
            if (gameObject.transform.rotation.y == 270.0f)
            {
                gameObject.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
            }
            else if (gameObject.transform.rotation.y == 0.0f)
            {
                gameObject.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
            }
            else if (gameObject.transform.rotation.y == 180.0f)
            {
                gameObject.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
            }
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0.0f, 0.0f, speed,Space.Self);
            PlayerAnimation.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0.0f, 0.0f, -speed, Space.Self);
            PlayerAnimation.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(speed, 0.0f, 0.0f, Space.Self);
            PlayerAnimation.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-speed, 0.0f, 0.0f, Space.Self);
            PlayerAnimation.SetBool("isWalking", true);
        }
        else
        {
            PlayerAnimation.SetBool("isWalking", false);
        }
    }
}
