using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");   
    }

    public void Creditos()
    {

    }

    // Update is called once per frame
    public void Sair()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
