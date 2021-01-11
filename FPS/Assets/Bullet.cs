using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Target型の「target」をつくる
    Target target;

    void Start()
    {
        //「target」に"Target"という名前のゲームオブジェクトの<Target>というスクリプトをセットする
        target = GameObject.Find("Target").GetComponent<Target>();
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Target")
        {

            //target(スクリプト)のDamage()関数を呼ぶ
            target.Damage();

            Destroy(gameObject);
        }
    }
}