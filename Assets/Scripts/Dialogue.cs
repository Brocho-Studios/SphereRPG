using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{

public void epicness () {   
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

}

}
