using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startmenuscript : MonoBehaviour {

    public void startbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void leaderboard()
    {
        SceneManager.LoadScene(3);
    }
    public void Creditsbutton()
    {
        SceneManager.LoadScene(4);
    }
    public void EXITGAME()
    {
        Application.Quit();
    }
}
