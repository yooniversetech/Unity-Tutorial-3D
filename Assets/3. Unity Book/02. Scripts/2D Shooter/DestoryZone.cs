using UnityEngine;

public class DestoryZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            PlayerFire.Instance.bulletObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else
        {
            EnemyManager.Instance.enemyObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }
}
