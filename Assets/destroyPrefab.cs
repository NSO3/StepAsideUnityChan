using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPrefab : MonoBehaviour {

    private GameObject unityChan;

    // Use this for initialization
    void Start () {
        this.unityChan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {

        if (this.unityChan.transform.position.z - 10 > this.gameObject.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
