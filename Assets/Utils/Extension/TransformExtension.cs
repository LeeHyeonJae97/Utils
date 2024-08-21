using UnityEngine;

public static class TransformExtension
{
    public static Transform SetPosition(this Transform tr, Vector3 position)
    {
        tr.position = position;
        
        return tr;
    }
    
    public static Transform SetPositionX(this Transform tr, float x)
    {
        tr.position = new Vector3(x, tr.position.y, tr.position.z);
        
        return tr;
    }
    
    public static Transform SetPositionY(this Transform tr, float y)
    {
        tr.position = new Vector3(tr.position.x, y, tr.position.z);
        
        return tr;
    }

    public static Transform SetPositionZ(this Transform tr, float z)
    {
        tr.position = new Vector3(tr.position.x, tr.position.y, z);

        return tr;
    }

    public static Transform SetLocalPosition(this Transform tr, Vector3 localPosition)
    {
        tr.localPosition = localPosition;

        return tr;
    }
    
    public static Transform SetLocalPositionX(this Transform tr, float localX)
    {
        tr.localPosition = new Vector3(localX, tr.localPosition.y, tr.localPosition.z);
        
        return tr;
    }
    
    public static Transform SetLocalPositionY(this Transform tr, float localY)
    {
        tr.localPosition = new Vector3(tr.localPosition.x, localY, tr.localPosition.z);
        
        return tr;
    }

    public static Transform SetLocalPositionZ(this Transform tr, float localZ)
    {
        tr.localPosition = new Vector3(tr.localPosition.x, tr.localPosition.y, localZ);

        return tr;
    }

    public static Transform SetRotation(this Transform tr, Quaternion rotation)
    {
        tr.rotation = rotation;

        return tr;
    }

    public static Transform SetLocalRotation(this Transform tr, Quaternion localRotation)
    {
        tr.localRotation = localRotation;

        return tr;
    }

    public static Transform SetLocalScale(this Transform tr, Vector3 localScale)
    {
        tr.localScale = localScale;

        return tr;
    }

    public static void SetParent(this Transform tr, Transform parent, Vector3 localPosition)
    {
        tr.SetParent(parent);
        tr.localPosition = localPosition;
    }

    public static void SetParent(this Transform tr, Transform parent, Vector3 localPosition, Quaternion localRotation)
    {
        tr.SetParent(parent);
        tr.localPosition = localPosition;
        tr.localRotation = localRotation;
    }

    public static void SetParent(this Transform tr, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)
    {
        tr.SetParent(parent);
        tr.localPosition = localPosition;
        tr.localRotation = localRotation;
        tr.localScale = localScale;
    }

    public static void MoveTowards(this Transform tr, Vector3 target, float speed)
    {
        tr.position = Vector3.MoveTowards(tr.position, target, speed);
    }

    public static void RotateTowards(this Transform tr, Quaternion lookRotation, float speed)
    {
        tr.rotation = Quaternion.RotateTowards(tr.rotation, lookRotation, speed);
    }

    public static void RotateTowards(this Transform tr, Vector3 lookTarget, float speed)
    {
        var lookRotation = Quaternion.LookRotation(lookTarget - tr.position);

        tr.rotation = Quaternion.RotateTowards(tr.rotation, lookRotation, speed);
    }
}
