using System.Collections.Generic;
using UnityEngine;

public class ObjectLoader : MonoBehaviour
{
    public Transform player;
    public float loadDistanceY = 10f;
    public LayerMask objectsLayer; 

    private HashSet<GameObject> loadedObjects = new HashSet<GameObject>();

    void Start()
    {
        DeactivateObjectsOutsideRange();
    }

    void Update()
    {
        UpdateObjectStates();
    }

    void DeactivateObjectsOutsideRange()
    {
        Collider2D[] allObjects = Physics2D.OverlapCircleAll(player.position, float.MaxValue, objectsLayer);

        foreach (Collider2D collider in allObjects)
        {
            GameObject obj = collider.gameObject;

            float distanceToPlayerY = Mathf.Abs(obj.transform.position.y - player.position.y);

            if (distanceToPlayerY > loadDistanceY)
            {
                obj.SetActive(false);
                loadedObjects.Add(obj);
            }
        }
    }

    void UpdateObjectStates()
    {
        foreach (GameObject obj in loadedObjects)
        {
            bool withinRange = IsWithinRange(obj);

            if (withinRange && !obj.activeSelf)
            {
                obj.SetActive(true);
            }
            else if (!withinRange && obj.activeSelf)
            {
                obj.SetActive(false);
            }
        }
    }

    bool IsWithinRange(GameObject obj)
    {
        float distanceToPlayerY = Mathf.Abs(obj.transform.position.y - player.position.y);
        return distanceToPlayerY <= loadDistanceY;
    }
}
