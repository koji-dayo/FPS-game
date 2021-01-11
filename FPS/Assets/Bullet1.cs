using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    //ぶつかったときに呼ばれるOnCollisionEnter関数
    void OnCollisionEnter(Collision col)
    {
        //もしぶつかったときのオブジェクトのタグが"Target"だったら
        if (col.gameObject.tag == "Target")
        {
            //自分自身(Bullet)のオブジェクトを消す
            Destroy(gameObject);
        }
    }
}
