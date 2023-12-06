using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 10f;
    [SerializeField]
    public float damage = 1f;
    private GameObject player;
    private bool playerFlip = true;

    private SpriteRenderer weaponSpriteRender;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1f);
        weaponSpriteRender = GetComponent<SpriteRenderer>();
        //GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //  보는 방향으로 무기 발사 성공을 했지만 쏘는 도중에 방향을 바꾸면 무기가 다시 바뀜
        if(GameObject.Find("Player").GetComponent<Player>().xflip == false){
        transform.position += Vector3.right * moveSpeed*Time.deltaTime;
        weaponSpriteRender.flipX = false;
        }else if(GameObject.Find("Player").GetComponent<Player>().xflip == true){
        transform.position += Vector3.left * moveSpeed*Time.deltaTime;
        weaponSpriteRender.flipX = true;
        }

    }
    
}
