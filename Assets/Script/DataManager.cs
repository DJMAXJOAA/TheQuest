using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<EnemyData> enemyData;
    public List<WeaponData> weaponData;
    public List<PostionData> postionData;

    // ΩÃ±€≈Ê
    public static DataManager instance;
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
}
