using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Math2D
{
    // Degrees
    public static float GetAngleBetweenPositions(Vector2 pos1, Vector2 pos2)
    {
        Vector2 delta = pos2 - pos1;
        return Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
    }

    public static Vector2 NormalizeVectorBetweenPositions(Vector2 pos1, Vector2 pos2)
    {
        Vector2 normalizedVector = (pos2 - pos1);
        normalizedVector.Normalize();
        return normalizedVector;
    }

    // Degrees
    public static float VectorToAngle(Vector2 vector)
    {
        return GetAngleBetweenPositions(new Vector2(0, 0), vector);
    }

    // Degrees
    public static Vector2 AngleToVector(float angle)
    {
        // TODO
        return new Vector2();
    }
    public static Vector2 GetMousePosition()
    {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }

}
