using UnityEngine;
using UnityEngine.Rendering;

public class Arrow : MonoBehaviour
{
    public float shootSpeed = 100f;
    public bool isShoot = true;

    private void Update()
    {
        if (!isShoot)
        {
            transform.position += transform.up * shootSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var closetPos = other.ClosestPoint(transform.position);

        transform.SetParent(other.transform);
        isShoot = false;
    }
}
