﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatusEffect
{
    Wet, Electric, Goo, Blunt, Fire
}

public class Battery : Interactable
{
    StatusEffect status;

    [Header("Battery Life")]
    public float fullBatteryLife = 100f;
    public float minBatteryLife = 0f;
    float batteryLife;

    [Header("Charge Modifiers")]
    [SerializeField] float initialDrainRate = 2f;
    [SerializeField] float initialRechargeRate = 1f;
    [SerializeField] float doubleDrainRate = 4f;
    [SerializeField] float doubleRechargeRate = 2f;
    [SerializeField] float slowDrainRate = 1f;
    [SerializeField] float slowRechargeRate = 0.5f;
    float drainRate;
    float rechargeRate;

    [Header("Battery Status")]
    public bool isSupplyingPower;
    public bool isCharging;


    public Battery(StatusEffect Status)
    {
        status = Status;
    }

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
        drainRate = initialDrainRate;
        rechargeRate = initialRechargeRate;
    }

    #region Interact Functions
    public override void Wet()
    {
        Debug.Log("Nothing");
    }

    public override void Electric()
    {
        rechargeRate = doubleRechargeRate;
        drainRate = slowDrainRate;
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
