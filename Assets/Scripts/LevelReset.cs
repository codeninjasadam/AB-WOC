using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem explotion;

    private void Start()
    {
        explotion.Stop();
    }
    public void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("Reload", 2);
        explotion.transform.position = transform.position;
        explotion.Play();
    }
    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}


