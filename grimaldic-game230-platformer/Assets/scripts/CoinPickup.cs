using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{


    [SerializeField] AudioClip coinPickupSFX;

  
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //This needs a vector3 after the variable name to place it at the camera's location 
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }


}
