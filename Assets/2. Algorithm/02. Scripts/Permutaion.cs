using NUnit.Framework;
using UnityEngine;

public class Permutaion : MonoBehaviour
{
    public int[] array = new int[3] { 1, 2, 3 };

    private void Start()
    {
        PermutaionFuncion(array, 0);
    }

    private void PermutaionFuncion(int[] arr, int start)
    {
        if (start == arr.Length)
        {
            Debug.Log(string.Join(", ", arr));
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            var temp = arr[start];
            arr[start] = arr[i];
            arr[i] = temp;

            PermutaionFuncion(arr, start + 1);

            temp = arr[start];
            arr[start] = arr[i];
            arr[i] = temp;
        }
    }
}