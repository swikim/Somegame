using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 10f;
    [SerializeField]
    public float damage = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right *moveSpeed*Time.deltaTime;

    }
}
