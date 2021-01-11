using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    //どこからでもアクセスできるDamage()関数をつくる
    public void Damage()
    {
        //float型の変数「timer」をつくり、0.3をセットする
        float timer = 0.3f;
        //自分自身のゲームオブジェクト（Target）を0.3待ってから削除する
        Destroy(gameObject, timer);
    }

}
