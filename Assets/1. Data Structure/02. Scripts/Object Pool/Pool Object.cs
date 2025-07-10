using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private ObjectPoolQueue pool;
    public float bulletSpeed = 100f;

    void Awake()
    {
        pool = FindFirstObjectByType<ObjectPoolQueue>();
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }

    void OnEnable()
    {
        Invoke("ReturnPool", 3f);
    }

    private void ReturnPool()
    {
        pool.EnqueueObject(gameObject);
    }
}
