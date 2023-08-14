using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Unit
{
    private void Start()
    {
        Init();
        RandomPos();
    }

    public abstract override void Move(Direction direction);
    public abstract void Init();
    public void MovePattern(IStrategy strategy)
    {
        strategy.MoveStrategy(this);
    }
    public void RandomPos()
    {
        int randomPosX = Random.Range(0, 11);
        int randomPosZ = Random.Range(0, 11);

        Vector3 randomPos = new Vector3(randomPosX, 1.5f, randomPosZ);
        transform.position = randomPos;
    }
}
