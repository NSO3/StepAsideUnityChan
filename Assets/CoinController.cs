using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{
    private GameObject unityChan;

    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        this.unityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);
        if (this.unityChan.transform.position.z -10 > this.gameObject.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}