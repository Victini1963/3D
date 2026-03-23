using UnityEngine;

public class Key : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        Inventory playerInventory = other.GetComponent<Inventory>();

        if (playerInventory != null)
        {
            playerInventory.KeyCollected();
            gameObject.SetActive(false);
            print("Collected");
        }
    }    

}
