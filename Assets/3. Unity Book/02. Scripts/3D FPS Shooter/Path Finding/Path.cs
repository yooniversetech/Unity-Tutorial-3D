using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UIElements;

public class Path : MonoBehaviour
{
    public Vector3[] points;
    public float radius = 2f;
    public Vector3 GetPoint(int index)
    {
        return points[index];
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < points.Length; i++)
        {
            if (i + 1 < points.Length)
            {
                Debug.DrawLine(points[i], points[i + 1], Color.blue);
            }
        }
    }
}
