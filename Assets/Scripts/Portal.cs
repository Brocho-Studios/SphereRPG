using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
void OnTriggerEnter (Collider player)
{   
if (player.transform.localScale == new Vector3(1.4f, 0.8002958f, 1.4f)) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
}