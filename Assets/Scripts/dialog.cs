using UnityEngine;
using UnityEngine.SceneManagement;

public class dialog : MonoBehaviour
{
void OnTriggerEnter (Collider player)
{   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}