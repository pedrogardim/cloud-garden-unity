using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunClickerController : MonoBehaviour
{
    GameController gameController;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        anim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.name == "Sun")
                {
                    gameController.addSun(1);
                    anim.SetTrigger("ScaleAnim");

                }
            }
        }
    }
}
