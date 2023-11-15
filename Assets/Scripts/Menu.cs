using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame () 
    {
        Debug.Log("Startin Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
