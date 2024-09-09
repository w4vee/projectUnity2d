using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointScript : MonoBehaviour
{
    public float delaySec = 0;
    public string nameScene = "Scene2";
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            ModeSelect();
        }
    }
    public void ModeSelect()
    {
        StartCoroutine(loadAfterDelay());
        
    }
    IEnumerator loadAfterDelay()
    {
        yield return new WaitForSeconds(delaySec);
        SceneManager.LoadScene(nameScene);
    }

}
