using UnityEngine;
using UnityEditor;
public class MenuScript
{
    // 유니티 에디터 맨 위에 도구창 생겨서 일괄 적용 가능
    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        // 태그로 찾아서 배열에 넣기
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
