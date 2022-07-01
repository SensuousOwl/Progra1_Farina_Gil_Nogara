using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerRobotTank))]
public class RobotInput : MonoBehaviour
{
    private PlayerRobotTank robot;

    [SerializeField] private KeyCode _moveForwardKey = KeyCode.W;
    [SerializeField] private KeyCode _moveBackwardKey = KeyCode.S;
    [SerializeField] private KeyCode _moveLeftdKey = KeyCode.A;
    [SerializeField] private KeyCode _moveRightKey = KeyCode.D;
    [SerializeField] private KeyCode _boostKey = KeyCode.LeftShift;

    private void Awake()
    {
        robot = GetComponent<PlayerRobotTank>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(_moveForwardKey)) robot.MoveForwardCommand.Do();
        if (Input.GetKey(_moveBackwardKey)) robot.MoveBackwardCommand.Do();
        if (Input.GetKey(_moveLeftdKey)) robot.MoveLeftCommand.Do();
        if (Input.GetKey(_moveRightKey)) robot.MoveRightCommand.Do();

        if (Input.GetKey (_boostKey)) robot.BoostCommand.Do();
    }
}
