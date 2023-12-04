using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject[] weapons;
    [SerializeField]
    private Transform ShootTransform;

    [SerializeField]
    private float moveSpeed = 10f;

    private float minY = -7;
    
    [SerializeField]
    private GameObject weapon;


    //float xMove,yMove;

    // Start is called before the first frame update
    void Start()
    {
        
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
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.localScale = new Vector3(1,1,1);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.localScale = new Vector3(-1,1,1);

        }
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
}
