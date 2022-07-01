using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _transform;
    private Transform _rotation;
    private Vector3 _direction;
    private float _speed;
    private float _zRotation;

    public MoveCommand(Transform transform, Vector3 direction, float speed, float zRotation)
    {
        _transform = transform; 
        _direction = direction;
        _speed = speed;
        _zRotation = zRotation;
    }
    public void Do()
    {
        _transform.position += _direction * Time.deltaTime * _speed;
        _transform.rotation = Quaternion.Euler(0, 0, _zRotation);
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
