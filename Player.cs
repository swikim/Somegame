using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject[] weapons;

    [SerializeField]
    private float moveSpeed = 10f;

    private float minY = -7;

    //float xMove,yMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if(transform.position.y < minY){
            Destroy(gameObject);
        }
    }
    void Shoot(){
        if(Input.GetKey("X")){
            Debug.Log("six");
        }
    }
}
