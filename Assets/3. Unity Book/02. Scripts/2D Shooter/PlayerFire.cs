using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFire : Singleton<PlayerFire>
{
    public GameObject bulletFactory;
    public GameObject firePosition;

    public int poolSize = 10;

    //public List<GameObject> bulletObjectPool;
    public Queue<GameObject> bulletObjectPool;

    private void Start()
    {
        bulletObjectPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            //bulletObjectPool[i] = bullet;
            bulletObjectPool.Enqueue(bullet);
            bullet.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
#if UNITY_STANDARDALONE || UNITY_EDITOR
            //큐
            if (bulletObjectPool.Count > 0)
            {
                GameObject bullet = bulletObjectPool.Dequeue();
                bullet.SetActive(true);
                bullet.transform.position = firePosition.transform.position;
            }

            //리스트
            //if (bulletObjectPool.Count > 0)
            //{
            //    GameObject bullet = bulletObjectPool[0];
            //    bullet.SetActive(true);

                //    bullet.transform.position = firePosition.transform.position;

                //    bulletObjectPool.Remove(bullet);
                //}

                //for (int i = 0; i < poolSize; i++)
                //{
                //    GameObject bullet = bulletObjectPool[i];

                //    if (!bullet.activeSelf)
                //    {
                //        bullet.SetActive(true);
                //        bullet.transform.position = firePosition.transform.position;

                //        break;
                //    }
                //}

                //GameObject bullet = Instantiate(bulletFactory);
                //bullet.transform.position = firePosirion.transform.position;
                //bullet.transform.rotation = firePosirion.transform.rotation;

                //bullet.transform.SetPositionAndRotation(위치, 회전);
                //bullet.transform.parent = 부모;
                //bullet.transform.SetParent(부모);
        }
#endif
    }
}
