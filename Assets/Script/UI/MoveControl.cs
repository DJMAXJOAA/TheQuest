using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    [SerializeField]
    Player player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void MoveLeft()
    {
        player.Move(Direction.LEFT);
    }
    public void MoveRight()
    {
        player.Move(Direction.RIGHT);
    }
    public void MoveUp()
    {
        player.Move(Direction.UP);
    }
    public void MoveDown()
    {
        player.Move(Direction.DOWN);
    }
}
