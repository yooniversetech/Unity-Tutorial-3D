using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float destroyTime = 2f;

    private float currentTime = 0f;

    private void Update()
    {
        if (currentTime < destroyTime)
        {
            Destroy(gameObject);
        }
        currentTime += Time.deltaTime;
    }
}
