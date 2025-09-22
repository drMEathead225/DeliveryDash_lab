using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Package"))
        {
            Debug.Log("Pickup up package");
            hasPackage = true;
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
        }




    }
}    
