using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    private float speed = 5;
    public GameObject explosionFactory;

    void OnEnable()
    {

        int ranValue = UnityEngine.Random.Range(0, 2);

        if (ranValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();

            //dir = dir.normalized;
        }
        else
        {
            dir = Vector3.down;
        }
    }
    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        ScoreManager.Instance.Score++;

        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        if (other.gameObject.name.Contains("Bullet"))
        {
            //PlayerFire player = GameObject.Find("Player").GetComponent<PlayerFire>();
            PlayerFire.Instance.bulletObjectPool.Enqueue(other.gameObject);
            //other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject);
        }
        EnemyManager.Instance.enemyObjectPool.Enqueue(gameObject);
        gameObject.SetActive(false);
    }
}
