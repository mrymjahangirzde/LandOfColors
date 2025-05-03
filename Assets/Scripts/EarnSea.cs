using UnityEngine;

public class EarnSea : MonoBehaviour
{
    public int s = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        s++;
        gameObject.SetActive(false);
    }
}
