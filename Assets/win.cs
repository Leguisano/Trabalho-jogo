using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("jogador")){
            SceneManager.LoadScene("win");
        }
    }
}
