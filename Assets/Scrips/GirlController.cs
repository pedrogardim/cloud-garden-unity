using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    public int speed = 1;
    public int power = 2;
    public bool direction = true; //direction ? right : left
    public Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;
    GameController gameController;
    GameObject littleSun;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        littleSun = gameObject.transform.GetChild(0).gameObject;
        rigidBody.velocity = new Vector3(speed * (direction ? 1 : -1), 0,0);
    }

    void Update()
    {

        
    }
    
    void OnCollisionEnter2D(Collision2D col){
        direction = !direction;
        spriteRenderer.flipX = !direction;
        rigidBody.velocity = new Vector3(speed * (direction ? 1 : -1), 0,0);

        if(col.gameObject.CompareTag("WalkStart")){
            gameController.addSun(power);
            littleSun.SetActive(false);
        }
        else{
            littleSun.SetActive(true);
        }

    }
}
