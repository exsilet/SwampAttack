using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    [SerializeField] private Blade _blade;
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(_blade, shootPoint.position, shootPoint.rotation);
    }
}
