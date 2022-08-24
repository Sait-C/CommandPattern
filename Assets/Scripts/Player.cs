using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    ICommand moveUp, moveLeft, moveRight, moveDown;

    [SerializeField]
    private float _speed = 10.0f;
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            CommandManager.Instance.AddCommand(moveUp);

        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            CommandManager.Instance.AddCommand(moveDown);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft = new MoveLeftCommand(this.transform, _speed);
            moveLeft.Execute();
            CommandManager.Instance.AddCommand(moveLeft);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
            CommandManager.Instance.AddCommand(moveRight);
        }
    }

   

}
