using UnityEngine;

public static class TransformExtension
{
    public static Transform SetPosition(this Transform transform, Vector3 position)
    {
        transform.position = position;
        
        return transform;
    }
    
    public static Transform SetPositionX(this Transform transform, float x)
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        
        return transform;
    }
    
    public static Transform SetPositionY(this Transform transform, float y)
    {
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        
        return transform;
    }

    public static Transform SetPositionZ(this Transform transform, float z)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, z);

        return transform;
    }

    public static Transform SetLocalPosition(this Transform transform, Vector3 localPosition)
    {
        transform.localPosition = localPosition;

        return transform;
    }
    
    public static Transform SetLocalPositionX(this Transform transform, float localX)
    {
        transform.localPosition = new Vector3(localX, transform.localPosition.y, transform.localPosition.z);
        
        return transform;
    }
    
    public static Transform SetLocalPositionY(this Transform transform, float localY)
    {
        transform.localPosition = new Vector3(transform.localPosition.x, localY, transform.localPosition.z);
        
        return transform;
    }

    public static Transform SetLocalPositionZ(this Transform transform, float localZ)
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, localZ);

        return transform;
    }

    public static Transform SetRotation(this Transform transform, Quaternion rotation)
    {
        transform.rotation = rotation;

        return transform;
    }

    public static Transform SetLocalRotation(this Transform transform, Quaternion localRotation)
    {
        transform.localRotation = localRotation;

        return transform;
    }

    public static Transform SetLocalScale(this Transform transform, Vector3 localScale)
    {
        transform.localScale = localScale;

        return transform;
    }

    public static void SetParent(this Transform transform, Transform parent, Vector3 localPosition)
    {
        transform.SetParent(parent);
        transform.localPosition = localPosition;
    }

    public static void SetParent(this Transform transform, Transform parent, Vector3 localPosition, Quaternion localRotation)
    {
        transform.SetParent(parent);
        transform.localPosition = localPosition;
        transform.localRotation = localRotation;
    }

    public static void SetParent(this Transform transform, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)
    {
        transform.SetParent(parent);
        transform.localPosition = localPosition;
        transform.localRotation = localRotation;
        transform.localScale = localScale;
    }

    public static void MoveTowards(this Transform transform, Vector3 target, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
    }

    public static void RotateTowards(this Transform transform, Quaternion lookRotation, float speed)
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, speed);
    }

    public static void RotateTowards(this Transform transform, Vector3 lookTarget, float speed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(lookTarget - transform.position);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, speed);
    }
}
