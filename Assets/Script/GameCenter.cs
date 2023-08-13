using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCenter : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;
    Transform movControl;
    public Transform MovControl { get { return movControl; } }

    Transform attackControl;
    public Transform AttackControl { get { return attackControl; } }

    Transform factory;
    GameObject player;
    GameObject[] tiles;

    // ΩÃ±€≈Ê
    public static GameCenter instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        factory = transform.GetChild(0);
        player = GameObject.FindGameObjectWithTag("Player");
        tiles = GameObject.FindGameObjectsWithTag("Tile");
        movControl = canvas.GetComponent<Transform>().GetChild(2);
        attackControl = canvas.GetComponent<Transform>().GetChild(3);
    }

    public void SetBtnInteract(Transform setControl, Direction direction, bool interact)
    {
        Button button;
        switch (direction)
        {
            case Direction.LEFT:
                button = setControl.GetChild(0).GetComponent<Button>();
                button.interactable = interact;
                break;
            case Direction.RIGHT:
                button = setControl.GetChild(1).GetComponent<Button>();
                button.interactable = interact;
                break;
            case Direction.UP:
                button = setControl.GetChild(2).GetComponent<Button>();
                button.interactable = interact;
                break;
            case Direction.DOWN:
                button = setControl.GetChild(3).GetComponent<Button>();
                button.interactable = interact;
                break;
        }
    }
}
