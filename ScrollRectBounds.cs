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
        // Get the current content position
        Vector3 contentPosition = contentRectTransform.localPosition;

        // Restrict the X position within the min and max bounds
        contentPosition.y = Mathf.Clamp(contentPosition.y, minScrollX, maxScrollX);

        // Update the content position
        contentRectTransform.localPosition = contentPosition;
    }
}
