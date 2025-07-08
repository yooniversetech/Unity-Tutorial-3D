using System.Collections.Generic;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();
    public int[] arr1 = new int[3] { 1, 2, 3 };
    public int[] arr2;

    private void Start()
    {
        stack = new Stack<int>(arr1);
        arr2 = stack.ToArray();

        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i);
        }

        Debug.Log(stack.Pop());
        Debug.Log(stack.Count);

        Debug.Log(stack.Peek());
        Debug.Log(stack.Count);

        Debug.Log(stack.Pop());
        Debug.Log(stack.Count);
    }
}
