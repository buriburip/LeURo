using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunIdle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        

        Vector3 worldPos = myTransform.position;
        Quaternion worldRot = myTransform.rotation;
        Animator anim = GetComponent<Animator>();

        float x = 0.0f;
        float y = 0.0f;
        float speed = 0.01f;

        
        if(Input.GetKey("up"))
        {
            y = 1.0f;
        }
        else if(Input.GetKey("down"))
        {
            y = -1.0f;
        }

        if (Input.GetKey("right"))
        {
            x = 1.0f;
            worldRot = Quaternion.Euler( 0f, 0f, 0f);
        }
        else if (Input.GetKey("left"))
        {
            x = -1.0f;
            worldRot = Quaternion.Euler( 0f, 180f, 0f);
        }
        
        if (x != 0f|| y != 0f) 
        {
            anim.SetBool("is_running",true);
            float radian = Mathf.Atan2(y,x);
            
            worldPos.x += Mathf.Cos(radian) * speed;
            worldPos.y += Mathf.Sin(radian) * speed;
            
            myTransform.position = worldPos; 
            myTransform.rotation = worldRot;
        }
        else
        {
            anim.SetBool("is_running",false);
        }
        
    }
}
