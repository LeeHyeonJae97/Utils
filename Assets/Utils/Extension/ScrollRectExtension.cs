using UnityEngine;
using UnityEngine.UI;

public static class ScrollRectExtension
{
    public static void Restrict(this ScrollRect scrollRect, RectTransform element)
    {
        RectTransform rectTransform = scrollRect.transform as RectTransform;
        RectTransform content = scrollRect.content;

        Vector2 size = element.rect.size;
        Vector2 center = element.GetLocalPositionWithPivot().TransformPoint(content).InverseTransformPoint(rectTransform);
        Vector2 position = center - size / 2;
        Rect elementRect = new Rect(position, size);

        size = rectTransform.rect.size;
        center = Vector2.zero;
        position = center - size / 2;
        Rect scrollRectRect = new Rect(position, size);

        Rect expandedElementRect = elementRect.Expand(scrollRectRect);

        if (!scrollRectRect.Contains(elementRect))
        {
            float diffX = (scrollRectRect.center.x - expandedElementRect.center.x) * 2;
            float diffY = (scrollRectRect.center.y - expandedElementRect.center.y) * 2;

            float x = content.anchoredPosition.x + diffX;
            float y = content.anchoredPosition.y + diffY;

            content.anchoredPosition = new Vector2(x, y);
        }
    }
}
