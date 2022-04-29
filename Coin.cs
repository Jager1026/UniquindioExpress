using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    public Vector3 moveDir;         // direction to move in
    public float moveSpeed;         // speed to move at along moveDir
   // private float aliveTime = 8.0f; // time before object is destroyed
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // move obstacle in certain direction over time
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        // rotate obstacle
        transform.Rotate(Vector3.back * moveDir.x * (moveSpeed * 20) * Time.deltaTime);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            animator.SetBool("wasPicked",true);
            Destroy(gameObject,1.0f);
        }
    }
}
