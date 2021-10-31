using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    [SerializeField] private int _damage;

    public LayerMask enemyLayer;
    public float attackDistance;

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, attackDistance, enemyLayer);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
            {
                enemy.TakeDamage(_damage);
                Destroy(gameObject, 0.01f);
            }
        }
        else
        {
            Destroy(gameObject, 0.8f);
        }
    }
}
