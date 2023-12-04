using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MainCamerController : MonoBehaviour
{
    [SerializeField]
    Transform  player;

    [SerializeField]
    float smoothing = 0.2f;
    [SerializeField] Vector2 maxCamemraBoundary;
    [SerializeField] Vector2 minCameraBoundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // private void LateUpdate() {
    //     UnityEngine.Vector3 targetPos = new UnityEngine.Vector3(player.position.x,player.position.y,this.transform.position.z);
    //     transform.position = targetPos;
       
    // }
    private void FixedUpdate() {
         Vector3 targetPos = new Vector3(player.position.x,player.position.y,this.transform.position.z);
         targetPos.x = Mathf.Clamp(targetPos.x,minCameraBoundary.x,maxCamemraBoundary.y);
         targetPos.y = Mathf.Clamp(targetPos.y,minCameraBoundary.y,maxCamemraBoundary.y);
        transform.position = Vector3.Lerp(transform.position,targetPos,smoothing);
    }
}

