using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{
    //どこからでもアクセスできるオブジェクト「bullet」をつくる
    public GameObject bullet;

    void Start()
    {

    }

    void Update()
    {
        //もし、マウスボタンがおされたら、Shot()関数にとぶ
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }

    }

    //Shot()関数をつくる
    void Shot()
    {
        //GameObject型の「obj」をつくる
        GameObject obj;
        //「obj」に「bullet」のインスタンス（クローン）をセットする
        obj = GameObject.Instantiate(bullet);
        //「obj」の位置座標に今の「Muzzle」の位置座標をセットする
        obj.transform.position = transform.position;
        //「obj」のRigidbody(重力)に、今の「Muzzle」のz軸方向に1000をかけたパワーを加える
        obj.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
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