using UnityEngine;

public class Inventory : MonoBehaviour
{
  

  public  static int NumberOfKeys {get; private set; }

  public void KeyCollected()
  {
    NumberOfKeys ++;
  }
}
