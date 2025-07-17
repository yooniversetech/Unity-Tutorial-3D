using UnityEngine;

public class PoolItem : MonoBehaviour
{
    private PoolManager poolManager;
    private bool isInit;

    private void Awake()
    {
        poolManager = GameObject.FindFirstObjectByType<PoolManager>();
    }

    private void Start()
    {
        if (!isInit)
        {
            isInit = true;
        }
        else
        {
            Invoke("ReturnObject", 3f);
        }
    }

    private void ReturnObject()
    {
        poolManager.pool.Release(gameObject);
    }
}
