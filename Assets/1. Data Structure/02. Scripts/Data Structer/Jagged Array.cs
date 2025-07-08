using UnityEngine;

public class JaggedArray : MonoBehaviour
{
    public int[] arr1 = new int[3];
    public int[][] jaggedArr1 = new int[3][]; // 배열이 3개가 있다는 뜻

    private void Start()
    {
        arr1[0] = 1;
        arr1[1] = 2;
        arr1[2] = 3;

        jaggedArr1[0] = new int[3] { 1, 2, 3 };
        jaggedArr1[1] = new int[2] { 9, 10 };
        jaggedArr1[2] = new int[5] { 7, 5, 2, 8, 4 };
    }
}
