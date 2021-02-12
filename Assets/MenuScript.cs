using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void Play()
    { 
        SceneManager.LoadScene("AR_Game_LVL0");
    }
    public void Exit()
    { 
        Application.Quit();
    }
}