using UnityEngine;
using UnityEngine.SceneManagement;

public class destruir : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("jogador")){
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("gameOver");
        }
    }
}
