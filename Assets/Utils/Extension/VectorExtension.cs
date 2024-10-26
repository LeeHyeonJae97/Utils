using UnityEngine;

public static class VectorExtension
{
    public static Vector2 SetX(this Vector2 vector, float x)
    {
        return new Vector2(x, vector.y);
    }

    public static Vector2 SetY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, y);
    }

    public static Vector3 SetX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }

    public static Vector3 SetY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y, vector.z);
    }

    public static Vector3 SetZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    public static Vector2Int SetX(this Vector2Int vector, int x)
    {
        return new Vector2Int(x, vector.y);
    }

    public static Vector2Int SetY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, y);
    }

    public static Vector3Int SetX(this Vector3Int vector, int x)
    {
        return new Vector3Int(x, vector.y, vector.z);
    }

    public static Vector3Int SetY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, y, vector.z);
    }

    public static Vector3Int SetZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, z);
    }

    public static Vector2Int ToInt(this Vector2 vector)
    {
        return new Vector2Int((int)vector.x, (int)vector.y);
    }

    public static Vector3Int ToInt(this Vector3 vector)
    {
        return new Vector3Int((int)vector.x, (int)vector.y, (int)vector.z);
    }

    public static Vector2 Round(this Vector2 vector)
    {
        return new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
    }

    public static Vector3 Round(this Vector3 vector)
    {
        return new Vector3(Mathf.Round(vector.x), Mathf.Round(vector.y), Mathf.Round(vector.z));
    }

    public static Vector2 Ceil(this Vector2 vector)
    {
        return new Vector2(Mathf.Ceil(vector.x), Mathf.Ceil(vector.y));
    }

    public static Vector3 Ceil(this Vector3 vector)
    {
        return new Vector3(Mathf.Ceil(vector.x), Mathf.Ceil(vector.y), Mathf.Ceil(vector.z));
    }

    public static Vector2 Floor(this Vector2 vector)
    {
        return new Vector2(Mathf.Floor(vector.x), Mathf.Floor(vector.y));
    }

    public static Vector3 Floor(this Vector3 vector)
    {
        return new Vector3(Mathf.Floor(vector.x), Mathf.Floor(vector.y), Mathf.Floor(vector.z));
    }

    public static Vector2 Abs(this Vector2 vector)
    {
        return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
    }

    public static Vector3 Abs(this Vector3 vector)
    {
        return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
    }

    public static Vector3 XYToXZ(this Vector2 vector)
    {
        return new Vector3(vector.x, 0, vector.y);
    }

    public static Vector2 XZToXY(this Vector3 vector)
    {
        return new Vector2(vector.x, vector.z);
    }

    public static int Snap4(this Vector2 vector)
    {
        return Snap(vector, 4);
    }

    public static int Snap8(this Vector2 vector)
    {
        return Snap(vector, 8);
    }

    private static int Snap(Vector2 vector, int count)
    {
        return (Mathf.RoundToInt(Mathf.Atan2(vector.y, vector.x) / (2 * Mathf.PI / count)) + count) % count;
    }

    public static float Dst(this Vector2 from, Vector2 to)
    {
        return (from - to).magnitude;
    }

    public static float Dst(this Vector3 from, Vector3 to)
    {
        return (from - to).magnitude;
    }

    public static float SqrDst(this Vector2 from, Vector2 to)
    {
        return (from - to).sqrMagnitude;
    }

    public static float SqrDst(this Vector3 from, Vector3 to)
    {
        return (from - to).sqrMagnitude;
    }

    public static Vector2 Clamp(this Vector2 vector, Vector2 min, Vector2 max)
    {
        return new Vector2(Mathf.Clamp(vector.x, min.x, max.x), Mathf.Clamp(vector.y, min.y, max.y));
    }

    public static Vector3 Clamp(this Vector3 vector, Vector3 min, Vector3 max)
    {
        return new Vector3(Mathf.Clamp(vector.x, min.x, max.x), Mathf.Clamp(vector.y, min.y, max.y), Mathf.Clamp(vector.z, min.z, max.z));
    }

    public static Vector2 Reflect(this Vector2 vector, Vector2 normal)
    {
        return vector + 2 * Vector2.Dot(vector * -1, normal.normalized) * normal;
    }

    public static Vector3 Reflect(this Vector3 vector, Vector3 normal)
    {
        return vector + 2 * Vector3.Dot(vector * -1, normal.normalized) * normal;
    }

    public static Vector3 TransformPoint(this Vector3 vector, Transform transform)
    {
        return transform.TransformPoint(vector);
    }

    public static Vector3 TransformDirection(this Vector3 vector, Transform transform)
    {
        return transform.TransformDirection(vector);
    }

    public static Vector3 TransformVector(this Vector3 vector, Transform transform)
    {
        return transform.TransformVector(vector);
    }

    public static Vector3 InverseTransformPoint(this Vector3 vector, Transform transform)
    {
        return transform.InverseTransformPoint(vector);
    }

    public static Vector3 InverseTransformDirection(this Vector3 vector, Transform transform)
    {
        return transform.InverseTransformDirection(vector);
    }

    public static Vector3 InverseTransformVector(this Vector3 vector, Transform transform)
    {
        return transform.InverseTransformVector(vector);
    }
}
