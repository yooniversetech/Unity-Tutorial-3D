using System.Collections;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrepab;

    public int rangeX = 5;
    public int rangeZ = 5;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

        }
    }

    void RespawnBomb()
    {
        float ranX = Random.Range(-rangeX, rangeX + 1);
        float ranZ = Random.Range(-rangeZ, rangeZ + 1);

        Vector3 ranPos = new Vector3(ranX, 10f, ranZ);

        Instantiate(bombPrepab,ranPos, Quaternion.identity);
    }
}
