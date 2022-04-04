using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedSlimeAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform EnemyTransform = this.transform;
        Vector3 EnemyPos = EnemyTransform.position;
        Quaternion EnemyRot = EnemyTransform.rotation;
        Animator anim = GetComponent<Animator>();

        Vector3 PlayerPos = GameObject.Find("Player_1").transform.position;


        float x = 0.0f;
        float y = 0.0f;
        float speed = 0.001f;
        Vector3 relatePos = PlayerPos - EnemyPos;
        float radian;

        //攻撃中は何もしない
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("SpikedSlime_Attack")) 
        {
            anim.SetBool("is_attack", false);
            return;
        }
        //radian計算
            if(relatePos.x != 0 || relatePos.y != 0){
                radian = Mathf.Atan2(relatePos.y, relatePos.x);
            }else radian = 0;

        //相対距離が近すぎなければ距離更新
        if(Mathf.Abs(Mathf.Cos(radian) * relatePos.x) + Mathf.Abs(Mathf.Sin(radian) * relatePos.y) > 1.0f)
        {
            //radianから動く距離向き計算
            EnemyPos.x += Mathf.Cos(radian) * speed;
            EnemyPos.y += Mathf.Sin(radian) * speed;
            if(radian < 90.0f * Mathf.Deg2Rad && -90.0f * Mathf.Deg2Rad < radian) EnemyRot = Quaternion.Euler( 0f, 0f, 0f);
            else if(90.0f * Mathf.Deg2Rad < radian || radian < -90.0f * Mathf.Deg2Rad) EnemyRot = Quaternion.Euler( 0f, 180f, 0f);

            //更新
            EnemyTransform.position = EnemyPos;
            EnemyTransform.rotation = EnemyRot;
            //anim.SetBool("is_run", true);
        }
        else
        {
            //  近すぎたら
            //anim.SetBool("is_run", false);
            anim.SetBool("is_attack", true);
        }
        

        Debug.Log(relatePos);

    }
}
