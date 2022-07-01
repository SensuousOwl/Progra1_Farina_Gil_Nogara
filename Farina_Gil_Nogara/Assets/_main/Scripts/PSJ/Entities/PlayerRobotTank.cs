using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRobotTank : MonoBehaviour
{
    public int Speed => _speed;
    [SerializeField] private int _speed = 5;

    public MoveCommand MoveForwardCommand => _moveForwardCommand;
    private MoveCommand _moveForwardCommand;
    public MoveCommand MoveBackwardCommand => _moveBackwardCommand;
    private MoveCommand _moveBackwardCommand;
    public MoveCommand MoveLeftCommand => _moveLeftCommand;
    private MoveCommand _moveLeftCommand;
    public MoveCommand MoveRightCommand => _moveRightCommand;
    private MoveCommand _moveRightCommand;

    public BoostCommand BoostCommand => _boostCommand;
    private BoostCommand _boostCommand;

    private void Start()
    {
        InitCommand();
    }
    private void InitCommand()
    {
        _moveForwardCommand = new MoveCommand(transform, transform.up, _speed, 0);
        _moveBackwardCommand = new MoveCommand(transform, -transform.up, _speed, 180);
        _moveLeftCommand = new MoveCommand(transform, -transform.right, _speed, 90);
        _moveRightCommand = new MoveCommand(transform, transform.right, _speed, 270);

        _boostCommand = new BoostCommand(this);
    }
}
