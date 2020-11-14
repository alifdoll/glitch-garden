using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{

    int currentScene;
    [SerializeField]int waitInSeconds;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            StartCoroutine(Loading());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Loading()
    {
        yield return new WaitForSeconds(waitInSeconds);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
}
