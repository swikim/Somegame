using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool xflip;

    [SerializeField]
    public GameObject[] weapons;
    [SerializeField]
    private Transform ShootTransform;

    [SerializeField]
    private float moveSpeed = 10f;

    private float minY = -7;
    
    [SerializeField]
    private GameObject weapon;
    private SpriteRenderer playerSpriteRender;

    //float xMove,yMove;

    // Start is called before the first frame update
    void Start()
    {
        playerSpriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    float scaleX = transform.localScale.x;
    float scaleY = transform.localScale.y;

    //     xMove = 0; 
    //     yMove = 0; 

    //           if (Input.GetKey(KeyCode.RightArrow)) 
    //                  xMove = moveSpeed * Time.deltaTime; 
    //           else if (Input.GetKey(KeyCode.LeftArrow)) 
    //                  xMove = -moveSpeed * Time.deltaTime;
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 moveTo=new Vector3(horizontalInput,verticalInput,0f);
        transform.position += moveTo * moveSpeed * Time.deltaTime;
         float playerMove = Input.GetAxis("Horizontal") * moveSpeed *Time.deltaTime;
        // if(Input.GetKeyDown(KeyCode.RightArrow)){
        //     transform.localScale = new Vector3(1,1,1);
        // }
        // if(Input.GetKeyDown(KeyCode.LeftArrow)){
        //     transform.localScale = new Vector3(-1,1,1);

        // }
        
        RightLeft();
        if(transform.position.y < minY){
            Destroy(gameObject);
        }
        Shoot();
    }
    void Shoot(){
        if(Input.GetKeyDown("x")){
            Instantiate(weapons[0],ShootTransform.position,Quaternion.identity);
            
        }
    }
    public void RightLeft(){
        if(Input.GetKey(KeyCode.RightArrow)){
            playerSpriteRender.flipX =false;
            xflip = false;
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            playerSpriteRender.flipX = true;
            xflip = true;
        }
    }
}
