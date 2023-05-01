using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Player S;

    [Header("Set in Inspector")]
    public float walkSpeed = 30;
    public GameObject playerModel;

    [Header("Set Dynamically")]
    public int Score = 0;
    public bool isPoweredUp = false;

    void Awake()
    {
        if (S == null)
            S = this;
        else
            Debug.LogError("Error: tried to make another player...");
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("up"))
        {
            pos.z += walkSpeed * Time.deltaTime;
            transform.position = pos;
        }
        else if (Input.GetKey("down"))
        {
            pos.z -= walkSpeed * Time.deltaTime;
            transform.position = pos;
        }

        if (Input.GetKey("right"))
        {
            pos.x += walkSpeed * Time.deltaTime;
            transform.position = pos;
        }
        else if (Input.GetKey("left"))
        {
            pos.x -= walkSpeed * Time.deltaTime;
            transform.position = pos;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Transform rootT = other.gameObject.transform.root;
        GameObject go = rootT.gameObject;

        if (go.tag == "Collectible")
        {
            isPoweredUp = true;
            Score += 300;
            Destroy(go);
        }
        else if(go.tag == "Enemy")
        {
            Destroy(playerModel);
            isPoweredUp = false;
            GameScript.S.RestartGame(3);
        }

        print("Collided with object: " + go.name);
    }
}
