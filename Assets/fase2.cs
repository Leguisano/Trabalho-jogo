using UnityEngine;
using UnityEngine.SceneManagement;

public class fase2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("jogador")){
            SceneManager.LoadScene("fase2");

        }
    }
}
