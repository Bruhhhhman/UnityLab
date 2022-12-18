using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public Transform attackpos;
    public float attackRange;
    public LayerMask whatisenemies;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Collider2D[] endamage = Physics2D.OverlapCircleAll(attackpos.position, attackRange, whatisenemies);
            for (int i = 0; i < endamage.Length; i++)
            {
                endamage[i].GetComponent<car>().signal();

            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackpos.position, attackRange);
    }
}
