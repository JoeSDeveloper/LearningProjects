using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Uh oh you hit something!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You may have run something over!");
    }
}
