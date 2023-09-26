using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    public class WeaponBaseClass : ScriptableObject
    {
        public string weaponName;
        public string weaponDesc;
        public float attackrate;
        public float damage;
        
        public RuntimeAnimatorController weaponAnimationController;
        public Sprite sprite;

        public virtual string getWeaponType()
        {
            return null;
        }

        public virtual float getRange()
        {
            return 0;
        }

        public virtual float getSize()
        {
            return 0;
        }
        
        public virtual GameObject getProjectilePrefab()
        {
            return null;
        }

        public virtual float getProjectileSpeed()
        {
            return 0;
        }
    }

    [CreateAssetMenu]
    public class Hitbox : WeaponBaseClass
    {
        [SerializeField]
        public string weaponType = "Hitbox";
        public float range;
        public float size;

        public override string getWeaponType()
        {
            return weaponType;
        }
        
        public override float getRange()
        {
            return range;
        }

        public override float getSize()
        {
            return size;
        }
    }

    [CreateAssetMenu]
    public class Hitscan : WeaponBaseClass
    {
        public string weaponType = "Hitscan";
        
        public override string getWeaponType()
        {
            return weaponType;
        }
    }

    [CreateAssetMenu]
    public class Projectile : WeaponBaseClass
    {
        public string weaponType = "Projectile";
        public float projectileSpeed;

        public override string getWeaponType()
        {
            return weaponType;
        }

        public override float getProjectileSpeed()
        {
            return projectileSpeed;
        }
    }
}