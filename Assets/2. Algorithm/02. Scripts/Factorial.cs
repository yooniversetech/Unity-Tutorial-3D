using UnityEngine;

public class Factorial : MonoBehaviour
{
    public int result;
    private void Start()
    {
        Debug.Log(FactorialFunction(9));
    }

    private int FactorialFunction(int n)
    {
        for (int i = n; i >= 1; i++)
        {
             result = n * FactorialFunction(n - 1);
        }
        return result;
    }
}
