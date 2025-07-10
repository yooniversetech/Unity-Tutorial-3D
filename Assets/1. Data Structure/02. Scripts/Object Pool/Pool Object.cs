using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private objectPoolQueue pool;
    public float bulletSpeed = 100f;

    void Awake()
    {
        pool = FindFirstObjectByType<ObjectPoolQueue>();
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltatime * bulletSpeed;
    }

    void OnEnable()
    {
        invoke("ReturnPool", 3f);
    }

    private void ReturnPool()
    {
        pool.EnqueueObject(gameObject);
    }
}
