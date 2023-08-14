using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyFactory : MonoBehaviour
{

    public abstract void CreateEnemy(List<GameObject> enemyType, List<GameObject> enemies);
}
