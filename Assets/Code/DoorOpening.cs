using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    public Animation wallAnim;
   
   private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && Inventory.NumberOfKeys > 0)
        {
            
            wallAnim.Play("WallMove");
        }
    }
}


