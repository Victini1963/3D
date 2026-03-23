using UnityEngine;

public class TownGate : MonoBehaviour
{
    public Animation DoorAnim;
   
   private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            DoorAnim.Play("DoorOpen");
        }
    }
}
