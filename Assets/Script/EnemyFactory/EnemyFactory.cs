using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyFactory : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();

    public List<GameObject> getUnit()
    {
        return enemies;
    }

    public abstract void CreateEnemy(List<GameObject> enemyList);
}
