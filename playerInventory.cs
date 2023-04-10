using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    List<object> inventory = new List<object>();
    class MeleeWeapons // creates a class for melee weapon creation
    {
        public string weaponName { get; set; }
        public float weaponDamage { get; set; }
        public float weaponRange { get; set; } // I literally have 0 idea how this will work so weapon range is just set to 10 rn
        public float weaponChargeTime { get; set; } // Charge time in seconds
        public float staminaUsage { get; set; } // How much stamina is used with every swing of the weapon
    }
    // basic starter melee weapons
    MeleeWeapons bat = new MeleeWeapons
    {
        weaponsName = "Bat",
        weaponsDamage = 10f,
        weaponsRange = 10f,
        weaponsChargeTime = 1.5f,
        staminaUsage = 10f
    };
    MeleeWeapons spikedBat = new MeleeWeapons
    {
        weaponsName = "Spiked Bat",
        weaponsDamage = 25f,
        weaponsRange = 10f,
        weaponsChargeTime = 1.5f,
        staminaUsage = 10f
    };
    MeleeWeapons knife = new MeleeWeapons
    {
        weaponsName = "Knife",
        weaponsDamage = 25f,
        weaponsRange = 10f, // will have a low range
        weaponsChargeTime = 0.5f,
        staminaUsage = 5f
    };
    MeleeWeapons sword = new MeleeWeapons
    {
        weaponsName = "Sword",
        weaponsDamage = 30f,
        weaponsRange = 10f, // will have a longer range
        weaponsChargeTime = 2f,
        staminaUsage = 15f
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
