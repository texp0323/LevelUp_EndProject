using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 10;

    private PlayerController playerControllerScripts;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScripts = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScripts.gameOver == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }
}
