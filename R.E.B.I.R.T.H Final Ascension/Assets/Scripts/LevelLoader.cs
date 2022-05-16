using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    //public Text progText;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronuosly(sceneIndex));
    }

    IEnumerator LoadAsynchronuosly (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f) * 0.05f;
            Debug.Log(progress);

            slider.value = progress;
            
            yield return null;
        }
    }
}
