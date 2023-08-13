using System.Collections.Generic;
using UnityEngine;

public class Stage3 : EnemyFactory
{
    public override void CreateEnemy(List<GameObject> enemyList)
    {
        enemies.Add(enemyList[0]);
        enemies.Add(enemyList[0]);
        enemies.Add(enemyList[1]);
        enemies.Add(enemyList[1]);
        enemies.Add(enemyList[2]);
        enemies.Add(enemyList[2]);
    }
}
