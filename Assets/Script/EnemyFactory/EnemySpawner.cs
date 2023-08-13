using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyList;
    EnemyFactory[] enemySpawner = null;

    void Start()
    {
        enemySpawner = new EnemyFactory[3];
        enemySpawner[0] = new Stage1();
        enemySpawner[1] = new Stage2();
        enemySpawner[2] = new Stage3();

        Stage1();
    }

    public void Stage1()
    {
        enemySpawner[0].CreateEnemy(enemyList);
    }
    public void Stage2()
    {
        enemySpawner[1].CreateEnemy(enemyList);
    }
    public void Stage3()
    {
        enemySpawner[2].CreateEnemy(enemyList);
    }

}