using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = Vector3(Input.GetAxis("Horizntal"), 0, Input.GetAxis("Vertical"));

        float move = Input.GetAxis("Vertical");
        float direction = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", move);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(jumpHash);
            
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.ResetTrigger(jumpHash);
        }

    }
}
