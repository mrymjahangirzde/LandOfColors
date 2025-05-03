using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnterLight : MonoBehaviour
{
    public GameObject LightEnable;
    void OnTriggerEnter2D(Collider2D collision)
    {
        LightEnable.SetActive(false);
        StartCoroutine(a());
    }
    IEnumerator a()
    {
        yield return new WaitForSeconds(2);

        if(SceneManager.GetActiveScene().name == "ExampleScene")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
