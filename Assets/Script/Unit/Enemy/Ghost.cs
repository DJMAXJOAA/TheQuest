using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ghost : Enemy
{
    public override void Move(Direction direction)
    {
        IStrategy strategy = this.AddComponent<TraceStrategy>();
        MovePattern(strategy);
    }

    public override void Init()
    {
        List<EnemyData> dataList = DataManager.instance.enemyData;
        EnemyData data = null;
        foreach (var item in dataList)
        {
            if(item.name == "Ghost")
            {
                data = item;
                break;
            }
        }

        if (data != null)
        {
            gameObject.GetComponent<Renderer>().material.color = data.color;
            hp = data.hp;
            atk = data.atk;
        }
    }
}
