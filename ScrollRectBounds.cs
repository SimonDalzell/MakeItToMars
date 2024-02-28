using UnityEngine;
using UnityEngine.UI;

public class ScrollRectBounds : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float minScrollX = 0f;
    public float maxScrollX = 100f;

    private RectTransform contentRectTransform;
    private RectTransform viewportRectTransform;

    void Start()
    {
        contentRectTransform = scrollRect.content.GetComponent<RectTransform>();
        viewportRectTransform = scrollRect.viewport.GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 contentPosition = contentRectTransform.localPosition;

        contentPosition.y = Mathf.Clamp(contentPosition.y, minScrollX, maxScrollX);

        contentRectTransform.localPosition = contentPosition;
    }
}
