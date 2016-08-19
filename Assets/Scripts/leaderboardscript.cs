using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class leaderboardscript : MonoBehaviour {
    public GameObject zone1go;
    public Text zone1text;

    public GameObject zone2go;
    public Text zone2text;

    public GameObject finishgo;
    public Text finishtext;

    public float zone1b;
    public float zone2b;
    public float finish;

    // Use this for initialization
    void Start () {
        zone1b = PlayerPrefs.GetFloat("bestzone1");
        zone2b = PlayerPrefs.GetFloat("bestzone2");
        finish = PlayerPrefs.GetFloat("bestfinish");

        zone1text = zone1go.GetComponent<Text>();
        zone1text.text = "Best Zone 1: " + zone1b.ToString("F2");

        zone2text = zone2go.GetComponent<Text>();
        zone2text.text = "Best Zone 2: " + zone2b.ToString("F2");

        finishtext = finishgo.GetComponent<Text>();
        finishtext.text = "Best Final Time:" + finish.ToString("F2");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void menubutton()
    {
        SceneManager.LoadScene(0);
    }
}
