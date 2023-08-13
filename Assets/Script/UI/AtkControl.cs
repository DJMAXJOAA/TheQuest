using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtkControl : MonoBehaviour
{
    [SerializeField]
    Player player;
    Button[] button;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        button = GetComponentsInChildren<Button>();
        foreach (var btn in button)
        {
            btn.interactable = false;
        }
    }

    public void AttackLeft()
    {
        player.Attack(Direction.LEFT);
    }
    public void AttackRight()
    {
        player.Attack(Direction.RIGHT);
    }
    public void AttackeUp()
    {
        player.Attack(Direction.UP);
    }
    public void AttackDown()
    {
        player.Attack(Direction.DOWN);
    }
}
