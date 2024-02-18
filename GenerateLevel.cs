using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject MoveDownPrefab;
    public GameObject DownPrefab;
    public GameObject UpPrefab;
    public GameObject MoveSmallPrefab;
    public GameObject SmallPrefab;

    void Start()
    {
        PlaceObjects();
    }

    void PlaceObjects()
    {
        GameObject enemyWalls = new GameObject("Enemy Walls");

        float minX = -0.5430689f;
        float maxX = 5.136931f;
        float minY = 5f;
        float maxY = 100f;

        InstantiateObjects(MoveDownPrefab, minX, minY, maxX, maxY, enemyWalls.transform);
        InstantiateObjects(DownPrefab, minX, minY, maxX, maxY, enemyWalls.transform);
        InstantiateObjects(UpPrefab, minX, minY, maxX, maxY, enemyWalls.transform);
        InstantiateObjects(MoveSmallPrefab, minX, minY, maxX, maxY, enemyWalls.transform);
        InstantiateObjects(SmallPrefab, minX, minY, maxX, maxY, enemyWalls.transform);
    }

    void InstantiateObjects(GameObject prefab, float xMin, float yMin, float xMax, float yMax, Transform parent)
    {
        int numberOfObjects = Random.Range(5, 15);

        for (int i = 0; i < numberOfObjects; i++)
        {
            float xPos = Random.Range(xMin, xMax);
            float yPos = Random.Range(yMin, yMax);

            Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(xPos, yPos), 3f);

            bool isValidPosition = true;

            foreach (var collider in colliders)
            {
                if (Mathf.Abs(xPos - collider.transform.position.x) < 3f || Mathf.Abs(yPos - collider.transform.position.y) < 3f)
                {
                    isValidPosition = false;
                    break;
                }
            }

            if (isValidPosition)
            {
                GameObject instantiatedObject = Instantiate(prefab, new Vector2(xPos, yPos), Quaternion.identity, parent);
            }
        }
    }
}
