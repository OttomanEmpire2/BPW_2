using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPowderReady : MonoBehaviour
{
    public PutPowderInBarrel inBarrel;

    public void DoneMakingGunpowder()
    {
        inBarrel.DoneMakingGunpowder();
    }
}
