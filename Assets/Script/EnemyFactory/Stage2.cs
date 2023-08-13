using System.Collections.Generic;
using UnityEngine;

public class Stage2 : EnemyFactory
{
    public override void CreateEnemy(List<GameObject> enemyList)
    {
        enemies.Add(enemyList[0]);
        enemies.Add(enemyList[0]);
        enemies.Add(enemyList[0]);
        enemies.Add(enemyList[1]);
        enemies.Add(enemyList[1]);
    }
}
