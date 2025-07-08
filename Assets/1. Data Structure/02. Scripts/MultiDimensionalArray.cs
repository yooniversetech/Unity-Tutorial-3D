using UnityEngine;

public class MultiDimensionalArray : MonoBehaviour
{
    public int[,] arr1 = new int[3, 3];
    public int[,,] arr2 = new int[3, 3, 3];

    private void Start()
    {
        int num1 = arr1[1, 0];
        int num2 = arr1[1, 0];
        int num3 = arr1[1, 1];
    }
}
