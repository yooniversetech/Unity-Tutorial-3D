using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    private void Update()
    {
        gameObject.transform.Translate(Vector3.right * 10 * Time.time);
    }
}
