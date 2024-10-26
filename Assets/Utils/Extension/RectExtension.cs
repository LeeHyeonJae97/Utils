using UnityEngine;

public static class RectExtension
{
    public static Rect Expand(this Rect rect, Rect other)
    {
        Vector2 min = Vector2.Min(rect.min, other.min);
        Vector2 max = Vector2.Max(rect.max, other.max);

        Vector2 position = min;
        Vector2 size = max - min;

        return new Rect(position, size);
    }

    public static bool Contains(this Rect rect, Rect other)
    {
        bool isOtherMinIn = rect.min.x <= other.min.x && rect.min.y <= other.min.y;
        bool isOtherMaxIn = rect.max.x >= other.min.x && rect.max.y >= other.max.y;

        return isOtherMinIn && isOtherMaxIn;
    }

    public static bool Intersects(this Rect rect, Rect other, out Rect intersection)
    {
        bool intersects = rect.max.x > other.min.x && rect.max.y > other.min.y;

        if (intersects)
        {
            Vector2 position = other.min;
            Vector2 size = rect.max - other.min;

            intersection = new Rect(position, size);
        }
        else
        {
            intersection = default(Rect);
        }

        return intersects;
    }
}
