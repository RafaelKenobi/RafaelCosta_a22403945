using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public delegate void apanharPower();
    public static event apanharPower power_up;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerScript player = collision.gameObject.GetComponent<PlayerScript>();
        if (player != null) 
        {
            power_up();
            Destroy(gameObject);
        }
    }

}
