using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SyncLevelLoader : MonoBehaviour
{
    public Slider slider;
    public GameObject loader;

    IEnumerator LoadAsynchronously()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync("30 Büyükşehir ve Zonguldak");


        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
        if (operation.isDone)
        {
            loader.SetActive(false);
            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        loader.SetActive(true);

        StartCoroutine(LoadAsynchronously());

    }

    // Update is called once per frame
    void Update()
    {
    }
}
