﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpCommand : ICommand
{
    private Transform _player;
    private float _speed;

    public  MoveUpCommand(Transform player, float speed)
    {
        this._speed = speed;
        this._player = player;
    }

    public void Execute()
    {
        _player.Translate(Vector3.up * _speed * Time.deltaTime);
    }

    public void Undue()
    {
        _player.Translate(Vector3.down * _speed * Time.deltaTime);
    }
}
