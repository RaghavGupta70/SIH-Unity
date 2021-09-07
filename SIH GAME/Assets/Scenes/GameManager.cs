using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;

    // Start is called before the first frame update
    void Start()
    {
        //create ball
        Instantiate(ball);

        //create two paddles
        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;
        /*paddle1.Init(true); //right paddle
        paddle2.Init(false); //left paddle*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
