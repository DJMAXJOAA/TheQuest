using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    int stage = 1;

    public List<GameObject> enemies = new List<GameObject>();

    public List<GameObject> enemyList;
    EnemyFactory[] enemySpawner = null;

    void Start()
    {
        enemySpawner = new EnemyFactory[3];
        enemySpawner[0] = new Stage1();
        enemySpawner[1] = new Stage2();
        enemySpawner[2] = new Stage3();
    }
    public void StageStart()
    {
        switch (stage)
        {
            case 1:
                Stage1();
                break;
            case 2:
                Stage2();
                break;
            case 3:
                Stage3();
                break;
            default:
                break;
        }
        stage++;
    }

    private void Stage1()
    {
        enemySpawner[0].CreateEnemy(enemyList, enemies);
    }
    private void Stage2()
    {
        enemySpawner[1].CreateEnemy(enemyList, enemies);
    }
    private void Stage3()
    {
        enemySpawner[2].CreateEnemy(enemyList, enemies);
    }

}
