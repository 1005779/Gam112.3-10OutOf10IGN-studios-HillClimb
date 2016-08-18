using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endlevelscreen : MonoBehaviour {
    //declare variables
    public float finishtime;
    public GameObject timedisplayGO;
    public Text Finishtimet;

    // Use this for initialization
    void Start () {
        finishtime = PlayerPrefs.GetFloat("finishtime");
        Finishtimet = timedisplayGO.GetComponent<Text>();
        Finishtimet.text = "Finish Time:" + finishtime.ToString("F2");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
