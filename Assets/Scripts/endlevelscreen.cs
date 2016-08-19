using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endlevelscreen : MonoBehaviour {
    //declare variables
    public float finishtime;
    public float zone1;
    public float zone2;
    public GameObject timedisplayGOtotal;
    public Text Finishtimetotal;
    public GameObject timedisplayGO1;
    public Text Finishtimet1;
    public GameObject timedisplayGO2;
    public Text Finishtimet2;
    public float bestfinish;
    public float bestzone1;
    public float bestzone2;
    public GameObject TextdisplayedGO;
    public Text textdisplayed;
    public bool changesmade = false;

    // Use this for initialization
    void Start()
    {
        //load the current high scores.
        bestfinish = PlayerPrefs.GetFloat("bestfinish");
        bestzone1 = PlayerPrefs.GetFloat("bestzone1");
        bestzone2 = PlayerPrefs.GetFloat("bestzone2");

        //get the attempted scores.
        finishtime = PlayerPrefs.GetFloat("finishtime");
        zone1 = PlayerPrefs.GetFloat("zone1");
        zone2 = PlayerPrefs.GetFloat("zone2");
        Finishtimetotal = timedisplayGOtotal.GetComponent<Text>();
        Finishtimetotal.text = "Final Time:" + finishtime.ToString("F2");
        Finishtimet1 = timedisplayGO1.GetComponent<Text>();
        Finishtimet1.text = "Zone 1 finish:" + zone1.ToString("F2");
        Finishtimet2 = timedisplayGO2.GetComponent<Text>();
        Finishtimet2.text = "zone 2 finish:" + zone2.ToString("F2");

        if (finishtime < bestfinish)
        {
            changesmade = true;
            PlayerPrefs.SetFloat("bestfinish", finishtime);
        }
        if (zone1 < bestzone1)
        {
            changesmade = true;
            PlayerPrefs.SetFloat("bestzone1", zone1);
        }
        if (zone1 < bestzone2)
        {
            changesmade = true;
            PlayerPrefs.SetFloat("bestzone2", zone2);
        }
        if (changesmade == true)
        {
            textdisplayed = TextdisplayedGO.GetComponent<Text>();
            textdisplayed.text = "Well Done You Set a New Record!";
        }
        else
        {
            textdisplayed = TextdisplayedGO.GetComponent<Text>();
            textdisplayed.text = "You Finished But no New Records Set!";
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
