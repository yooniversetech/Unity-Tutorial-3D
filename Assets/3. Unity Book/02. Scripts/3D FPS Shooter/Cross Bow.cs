using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CrossBow : MonoBehaviour
{
    public GameObject arrowPerfab;
    public Transform shootPos;
    public bool isShoot;

    private void Update()
    {
        Ray ray = new Ray(shootPos.position, shootPos.forward);
        RaycastHit hit;

        bool isTargeting = Physics.Raycast(ray, out hit);

        Debug.DrawRay(shootPos.position, shootPos.forward * 100f, Color.green);

        if (isTargeting && !isShoot)
        {
            StartCoroutine(ShootRoutine());
        }
    }

    IEnumerator ShootRoutine()
    {
        isShoot = true;

        GameObject arrow = Instantiate(arrowPerfab, transform);
        Quaternion rot = Quaternion.Euler(90, 0, 0);
        arrow.transform.SetPositionAndRotation(shootPos.position, rot);
        
        yield return new WaitForSeconds(3f);
        isShoot = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(shootPos.position, shootPos.forward * 100f);
    }
}
