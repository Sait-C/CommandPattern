﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private Transform _player;
    private float _speed;

    public MoveLeftCommand(Transform player, float speed)
    {
        this._speed = speed;
        this._player = player;
    }

    public void Execute()
    {
        _player.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    public void Undue()
    {
        _player.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
