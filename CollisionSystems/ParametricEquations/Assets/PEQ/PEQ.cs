using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEQ : MonoBehaviour
{
    
    public static Vector3 Circle(float t, float a = 2)
    {
        float x = a * Mathf.Cos(t);
        float y = a * Mathf.Sin(t);
        float z = 0f;

        return new Vector3(x, y, z);
    }

    public static Vector3 Astroid(float t, float a = 1)
    {
        float x = a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = a * Mathf.Pow(Mathf.Sin(t), 3);
        float z = 0f;

        return new Vector3(x, y, z);
    }

    public static Vector3 Epicycloid(float t, float a = 5, float b = 1)
    {
        float x = (a + b) * Mathf.Cos(t) - b * Mathf.Cos((a / b + 1) * t);
        float y = (a + b) * Mathf.Sin(t) - b * Mathf.Sin((a / b + 1) * t);
        float z = 0f;

        return new Vector3(x, y, z);
    }

    public static Vector3 Hypocycloid(float t, float a = 5f, float b = 2f)
    {
        float x = (a - b) * Mathf.Cos(t) + b * Mathf.Cos((a / b - 1) * t);
        float y = (a - b) * Mathf.Sin(t) - b * Mathf.Sin((a / b - 1) * t);
        float z = 0f;

        return new Vector3(x, y, z);
    }

    public static Vector3 FreethsNephroid(float theta, float a = 2)
    {
        float r = a * (1 + 2 * Mathf.Sin(theta / 2));
        return ToPolar(r, theta);
    }

    public static Vector3 Rhodonea( float theta, float a = 3, float k = 9)
    {
        float r = a * Mathf.Sin(k * theta);
        return ToPolar(r, theta);

    }

    public static Vector3 Cissoid(float theta, float a = 3)
    {
        float r = 2 * a * Mathf.Tan(theta) * Mathf.Sin(theta);
        return ToPolar(r, theta);
    }

    public static Vector3 Circle3D(float t, float a = 2)
    {
        float x = a * Mathf.Cos(t);
        float y = a * Mathf.Sin(t);
        float z = a * t * Mathf.Sin(t) * Mathf.Cos(t);

        return new Vector3(x, y, z);

    }

    private static Vector3 ToPolar(float r, float theta)
    {
        return new Vector3(r * Mathf.Cos(theta), r * Mathf.Sin(theta), 0);
    }

}
