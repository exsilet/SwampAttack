using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutgun : Weapon
{
    [SerializeField] private List<Bullet> _shutBullet;

    public override void Shoot(Transform shootPoint)
    {
        foreach (var bullets in _shutBullet)
        {
            Instantiate(bullets, shootPoint.position, Quaternion.identity);
        }
    }
}
