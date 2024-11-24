using UnityEngine;

public class cair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
      private void OnTriggerEnter(Collider other)
    {
        // Se estiver usando Trigger, o funcionamento é similar
        if (other.CompareTag("jogador"))
        {
            Vector3 newPosition = new Vector3(transform.position.x, 0f, transform.position.z);
            transform.position = newPosition;
        }
    }


}
