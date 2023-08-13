using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStrategy
{
    void MoveStrategy(Enemy enemy);
}