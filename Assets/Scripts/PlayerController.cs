using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    //variables
    public Slider powerbar;
    public float targetspeed;
    public float currentspeed = 0;
    public float acceleration = 0.01f;
    public int terrainimin = 0;
    public GameObject mudeffect;
    public Text timetodisplay;
    public GameObject timeobject;
    public bool ispaused = false;
    public GameObject menuGO;

    public GameObject zone1go;
    public Text zone1text;
    public GameObject zone1bgo;
    public Text zone1btext;

    public GameObject zone2go;
    public Text zone2text;
    public GameObject zone2bgo;
    public Text zone2btext;
    public float bestz1;
    public float bestz2;

    public AudioClip engine;
    public float enginetimer;
    public float enginetimercool = 3;
    public bool engineplayed = false;


    public float GameTime = 0;
	// Use this for initialization
	void Start () {
        enginetimer = enginetimercool;
        Time.timeScale = 1;
        bestz1 = PlayerPrefs.GetFloat("bestzone1");
        bestz2 = PlayerPrefs.GetFloat("bestzone2");
        zone1btext = zone1bgo.GetComponent<Text>();
        zone1btext.text = "Zone 1 Best:" + bestz1.ToString("F2");
        zone2btext = zone2bgo.GetComponent<Text>();
        zone2btext.text = "Zone 2 Best:" + bestz2.ToString("F2");

    }
	
	// Update is called once per frame
	void Update () {
        GUIUPDATE();
        GameTime += Time.deltaTime;
        Movement();
        targetspeed = powerbar.value *10;
        if (currentspeed > 0.3)
        {
            mudeffect.SetActive(true);
        }
        else
        {
            mudeffect.SetActive(false);
        }
    }
    public void GUIUPDATE()
    {
        timetodisplay = timeobject.GetComponent<Text>();
        timetodisplay.text = "Time:" + GameTime.ToString("F2");
        enginetimer -= Time.deltaTime;
        if (enginetimer <= 0)
        {
            engineplayed = false;
            enginetimer = enginetimercool;
        }
        if (currentspeed > 0.2f && engineplayed == false)
        {
            AudioSource.PlayClipAtPoint(engine, this.transform.position);
            engineplayed = true;
        }
    }
    public void Movement()
    {
        if (terrainimin == 0)
        {
            acceleration = Time.deltaTime ;
        }
        if (terrainimin == 1)
        {
            if (powerbar.value < 0.2f)
            {
                acceleration = Time.deltaTime/2;
            }
            else if (powerbar.value >= 0.2f && powerbar.value < 0.4f)
            {
                acceleration = Time.deltaTime/3;
            }
            else if (powerbar.value >= 0.4f && powerbar.value < 0.6f)
            {
                acceleration = Time.deltaTime/4;
            }
            else if (powerbar.value >= 0.6f && powerbar.value < 0.8f)
            {
                acceleration = -Time.deltaTime/2;
            }
            else if (powerbar.value >= 0.8f && powerbar.value <= 1f)
            {
                acceleration = -Time.deltaTime;
            }
        }
        if (terrainimin == 2)
        {
            if (powerbar.value < 0.2f)
            {
                acceleration = Time.deltaTime;
            }
            else if (powerbar.value >= 0.2f && powerbar.value < 0.4f)
            {
                acceleration = Time.deltaTime / 1.5f;
            }
            else if (powerbar.value >= 0.4f && powerbar.value < 0.6f)
            {
                acceleration = Time.deltaTime / 2;
            }
            else if (powerbar.value >= 0.6f && powerbar.value < 0.8f)
            {
                acceleration = -Time.deltaTime / 1.5f;
            }
            else if (powerbar.value >= 0.8f && powerbar.value <= 1f)
            {
                acceleration = -Time.deltaTime;
            }
        }
        if (terrainimin == 3)
        {
            if (powerbar.value < 0.2f)
            {
                acceleration = Time.deltaTime;
            }
            else if (powerbar.value >= 0.2f && powerbar.value < 0.4f)
            {
                acceleration = Time.deltaTime / 1.5f;
            }
            else if (powerbar.value >= 0.4f && powerbar.value < 0.6f)
            {
                acceleration = Time.deltaTime / 2;
            }
            else if (powerbar.value >= 0.6f && powerbar.value < 0.8f)
            {
                acceleration = Time.deltaTime / 2.5f;
            }
            else if (powerbar.value >= 0.8f && powerbar.value <= 1f)
            {
                acceleration = -Time.deltaTime *2;
            }
        }
        if (currentspeed < targetspeed)
        {
            currentspeed += acceleration;
        }
        else
        {
            if (currentspeed > 0)
            {
                currentspeed -= 0.015f;
            }
        }
        transform.position += transform.forward * currentspeed * Time.deltaTime;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Terrain1")
        {
            terrainimin = 1;
        }
        if (other.gameObject.name == "Terrain0")
        {
            terrainimin = 0;
        }
        if (other.gameObject.name == "Terrain2")
        {
            terrainimin = 2;
        }
        if (other.gameObject.name == "Terrain3")
        {
            terrainimin = 3;
        }
        if (other.gameObject.tag == "finish")
        {
            PlayerPrefs.SetFloat("finishtime" ,GameTime);
            SceneManager.LoadScene(2); 
        }
        if (other.gameObject.tag == "zone1")
        {
            PlayerPrefs.SetFloat("zone1", GameTime);
            zone1text = zone1go.GetComponent<Text>();
            zone1text.text = "Zone 1:" + GameTime.ToString("F2");
        }
        if (other.gameObject.tag == "zone2")
        {
            PlayerPrefs.SetFloat("zone2", GameTime);
            zone2text = zone2go.GetComponent<Text>();
            zone2text.text = "Zone 2:" + GameTime.ToString("F2");
        }
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void exitbutton()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void pausebutton()
    {
        if (ispaused == false)
        {
            menuGO.SetActive(true);
            Time.timeScale = 0;
            ispaused = true;
        }
        else if (ispaused == true)
        {
            menuGO.SetActive(false);
            Time.timeScale = 1;
            ispaused = false;
        }
    }

}
