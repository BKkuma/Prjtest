using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    //[SerializeField] private int healthPoint = 2;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
  


    }
    private void Attack()
    {
        animator.SetTrigger("Walk");
    }
    private void Die()
    {
        animator.SetBool("Die", true);
        Destroy(gameObject, 2);

    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
        
    }
}
