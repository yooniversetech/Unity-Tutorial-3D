using UnityEngine;

public class FPSPlayerFire : MonoBehaviour
{
    public GameObject firePosition;

    public GameObject bombFactory;

    public float throwPower = 15f;
    public int weaponPower = 5;

    public GameObject bulletEffect;
    public ParticleSystem ps;
    private void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (FPSGameManager.Instance.gState != FPSGameManager.GameState.Run)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo = new RaycastHit();

            if (Physics.Raycast(ray, out hitInfo))// 반환해버리면 아래의 부분은 실행되지 않으니 매개변수로 out을 사용하여 넣어준다
            {
                if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    EnemyFSM eFSM = hitInfo.transform.GetComponent<EnemyFSM>();
                    eFSM.HitEnemy(weaponPower);
                }
                else
                {
                    bulletEffect.transform.position = hitInfo.point;
                    bulletEffect.transform.forward = hitInfo.normal;

                    ps.Play();
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject bomb = Instantiate(bombFactory);
            bomb.transform.position = firePosition.transform.position;

            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
        }
    }
}
