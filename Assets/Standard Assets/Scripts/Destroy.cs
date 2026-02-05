using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    [SerializeField] GameObject BloodVFX;
    [SerializeField] GameObject MeatVFX;
    void OnMouseDown()
    {
        GameObject explosion1 = Instantiate(BloodVFX, transform.position, transform.rotation);

        // Destroy the GameObject this script is attached to
        Destroy(gameObject);



    }
}
