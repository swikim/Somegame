using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [SerializeField]
    public float hp =10f;
    [SerializeField]
    private GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Weapon weapon = other.gameObject.GetComponent<Weapon>();
        hp -= weapon.damage;
        if(hp<=0){
            Destroy(gameObject);
            Instantiate(coin,transform.position,Quaternion.identity);
        }
        Destroy(other.gameObject);
    }
}
