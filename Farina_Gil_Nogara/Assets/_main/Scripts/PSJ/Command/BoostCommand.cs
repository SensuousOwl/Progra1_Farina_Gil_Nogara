using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostCommand : ICommand
{
    private PlayerRobotTank _entity;

    public BoostCommand(PlayerRobotTank entity)
    {
        _entity = entity;
    }
    public void Do()
    {
        _entity.GetComponent<Boost>().Do();
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
