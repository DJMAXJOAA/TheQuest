using UnityEngine;
using UnityEditor;
public class MenuScript
{
    // ����Ƽ ������ �� ���� ����â ���ܼ� �ϰ� ���� ����
    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        // �±׷� ã�Ƽ� �迭�� �ֱ�
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");
        
        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
    public static void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject t in tiles)
        {
            t.AddComponent<Tile>();
        }
    }
}
