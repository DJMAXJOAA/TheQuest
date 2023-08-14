using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Stage1 : EnemyFactory
{
    public override void CreateEnemy(List<GameObject> enemyList, List<GameObject> enemies)
    {
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[0]));
        enemies.Add(Instantiate(enemyList[0]));
    }
}
