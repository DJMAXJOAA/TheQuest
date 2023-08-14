using System.Collections.Generic;
using UnityEngine;

public class Stage3 : EnemyFactory
{
    public override void CreateEnemy(List<GameObject> enemyList, List<GameObject> enemies)
    {
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[1]));
        enemies.Add(Instantiate(enemyList[1]));
        enemies.Add(Instantiate(enemyList[2]));
        enemies.Add(Instantiate(enemyList[2]));
    }
}
