using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 minValues, maxValues;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, -1);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, -1);
    }

    
}
