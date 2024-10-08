using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;
    [SerializeField] float delay;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oops!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor; 
            Destroy(other.gameObject, 0.1f);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Successfully delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
