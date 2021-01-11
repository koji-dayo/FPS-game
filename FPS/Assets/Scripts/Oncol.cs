using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet")
        {
            // 衝突した相手を闇の彼方に消し去ります。
            Destroy(other.gameObject);
        }
    }
}
