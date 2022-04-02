using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Debug.Log(this.transform.position);

        Vector3 worldPos = myTransform.position;
        Quaternion worldRot = myTransform.rotation;
        Animator anim = GetComponent<Animator>();

        float x = 0.0f;
        float y = 0.0f;
        float speed = 0.01f;

        //攻撃モーション中は動かない
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Player_Attack1") || anim.GetCurrentAnimatorStateInfo(0).IsName("Player_Attack2")) 
        {
            anim.SetBool("is_attack1", false);
            anim.SetBool("is_attack2", false);
            return;
        }
        //攻撃モーション
        if(Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("is_attack1", true);
            return;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("is_attack2", true);
            return;
        }
        

        //移動と向き
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
            
            worldPos.x = -10 < worldPos.x + Mathf.Cos(radian) * speed && worldPos.x + Mathf.Cos(radian) * speed < 10 ? worldPos.x + Mathf.Cos(radian) * speed : worldPos.x;
            worldPos.y = -5  < worldPos.y + Mathf.Sin(radian) * speed && worldPos.y + Mathf.Sin(radian) * speed < 5  ? worldPos.y + Mathf.Sin(radian) * speed : worldPos.y;
            myTransform.position = worldPos;
            myTransform.rotation = worldRot;
        }
        else
        {
            anim.SetBool("is_running",false);
        }
        
    }
}
