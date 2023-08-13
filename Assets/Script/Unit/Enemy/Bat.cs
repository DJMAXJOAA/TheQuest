using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Bat : Enemy
{
    public override void Move(Direction direction)
    {
        IStrategy strategy = this.AddComponent<RandomStrategy>();
        MovePattern(strategy);
    }

    public override void Init()
    {
        List<EnemyData> dataList = DataManager.instance.enemyData;
        EnemyData data = null;
        foreach (var item in dataList)
        {
            if(item.name == "Bat")
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
