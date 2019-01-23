using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : Interactable
{
    [Header("Battery Life")]
    public float fullBatteryLife = 100f;
    public float minBatteryLife = 0f;
    float batteryLife;

    [Header("Charge Modifiers")]
    [SerializeField] float drainRate = 2f;
    [SerializeField] float rechargeRate = 1f;

    [Header("Battery Status")]
    public bool isSupplyingPower;
    public bool isCharging;


    void Start()
    {
        SetStats();
    }

    void Update()
    {
        CheckBatteryStatus();
    }

    void DrainBatteryLife()
    {
        if (batteryLife > minBatteryLife)
        {
            batteryLife -= drainRate * Time.deltaTime;
        }
    }

    void RechargeBattery()
    {
        if (batteryLife < fullBatteryLife)
        {
            batteryLife += rechargeRate * Time.deltaTime;
        }
    }

    void CheckBatteryStatus()
    {
        if (isSupplyingPower)
        {
            DrainBatteryLife();
        }

        if (isCharging)
        {
            RechargeBattery();
        }
    }

    void SetStats()
    {
        batteryLife = fullBatteryLife;
    }

    #region Interact Functions
    public override void Wet()
    {
        Debug.Log("Do Wet Thing");
    }

    public override void Electric()
    {
        Debug.Log("Do Electric Thing");
    }

    public override void Goo()
    {
        Debug.Log("Do Goo Thing");
    }

    public override void Blunt()
    {
        Debug.Log("Do Blunt Thing");
    }

    public override void Fire()
    {
        Debug.Log("Do Fire Thing");
    }
    #endregion
}
