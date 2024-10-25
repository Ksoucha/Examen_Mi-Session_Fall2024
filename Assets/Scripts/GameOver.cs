using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string MainScene;

    void Start()
    {
        StartCoroutine(ReturnToMainSceneAfterSeconds());
    }

    IEnumerator ReturnToMainSceneAfterSeconds()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(MainScene);
    }
}
