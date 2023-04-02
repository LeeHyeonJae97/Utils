using UnityEngine;

public static class RandomExtension
{
    public static Vector2 insideUnitCircle => Random.insideUnitCircle;
    public static Vector2 insideUnitRect { get { return new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)); } }
    public static Vector3 insideUnitRectXZ
    {
        get
        {
            var vec = insideUnitRect;

            return new Vector3(vec.x, 0, vec.y);
        }
    }
    public static Vector2 insideUnitSphere => Random.insideUnitSphere;
    public static Vector2 onUnitRect
    {
        get
        {
            int random = Random.Range(0, 4);
            switch (random)
            {
                case 0:
                    return new Vector2(-1, Random.value * 2 - 1);

                case 1:
                    return new Vector2(1, Random.value * 2 - 1);

                case 2:
                    return new Vector2(Random.value * 2 - 1, -1);

                case 3:
                    return new Vector2(Random.value * 2 - 1, 1);

                default:
                    return Vector2.zero;
            }
        }
    }
    public static Vector3 onUnitRectXZ
    {
        get
        {
            var vec = onUnitRect;

            return new Vector3(vec.x, 0, vec.y);
        }
    }
    public static Vector3 onUnitSphere => Random.onUnitSphere;
    public static Quaternion rotation => Random.rotation;
    public static Quaternion rotationUniform => Random.rotationUniform;
    public static Random.State state => Random.state;
    public static float value => Random.value;

    public static Color ColorHSV()
    {
        return Random.ColorHSV();
    }

    public static Color ColorHSV(float hueMin, float hueMax)
    {
        return Random.ColorHSV(hueMin, hueMax);
    }

    public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
    {
        return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax);
    }

    public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
    {
        return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);
    }

    public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
    {
        return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, alphaMin, alphaMax);
    }

    public static void InitState(int seed)
    {
        Random.InitState(seed);
    }

    public static int Range(int minInclusive, int maxExclusive)
    {
        return Random.Range(minInclusive, maxExclusive);
    }

    public static float Range(float minInclusive, float maxInclusive)
    {
        return Random.Range(minInclusive, maxInclusive);
    }    
}