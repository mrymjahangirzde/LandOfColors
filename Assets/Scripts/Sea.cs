using UnityEngine;
using UnityEngine.SceneManagement;

public class Sea : MonoBehaviour
{
    public EarnSea s;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(s.s <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
