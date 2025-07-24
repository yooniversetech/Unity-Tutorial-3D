using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FPSPlayerMove : MonoBehaviour
{
    private CharacterController cc;
    private Animator anim;

    public float moveSpeed = 7f;

    private float gravity = -20f;
    private float yVelocity = 0f;

    public float jumpPower = 10f;
    public bool isJumping = false;

    public int hp = 20;

    private int maxHp = 20;
    public Slider hpSlider;

    public GameObject hitEffect;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        if (FPSGameManager.Instance.gState != FPSGameManager.GameState.Run)
            return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3 (h, 0, v); // 크기와 방향이 있는 벡터
        dir = dir.normalized; // 방향 벡터

        anim.SetFloat("MoveMotion", dir.magnitude);

        dir = Camera.main.transform.TransformDirection(dir); // 카메라의 트랜스폼 기준으로 변환

        //transform.position += dir * moveSpeed * Time.deltaTime;

        // 가상중력 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime); // 캐릭터 컨트롤러 컴포넌트에 내장된 기능

        if (cc.collisionFlags == CollisionFlags.Below) //CollisionFlags.Below는 아래쪽에 무엇인가 닿아있을 때
        {
            if (isJumping)
            {
                isJumping = false;
            }
            yVelocity = 0f;
        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            yVelocity = jumpPower;
        }
    }

    public void DamageAction(int damage)
    {
        hp -= damage;

        hpSlider.value = (float)hp / (float)maxHp;
        
        if (hp > 0)
        {
            StartCoroutine(PlayHitEffect());
        }
    }


    IEnumerator PlayHitEffect()
    {
        hitEffect.SetActive(true);

        yield return new WaitForSeconds(0.25f);
        hitEffect.SetActive(false);
    }

    void Jump()
    {

    }
}
