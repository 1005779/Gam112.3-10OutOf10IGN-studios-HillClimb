using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class flipscript : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            SceneManager.LoadScene(1);
        }
    }
}
