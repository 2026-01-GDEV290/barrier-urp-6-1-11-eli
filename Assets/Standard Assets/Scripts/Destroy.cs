using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    [SerializeField] GameObject BloodVFX;
    public AudioClip clip;
    void OnMouseDown()
    {
        GameObject explosion1 = Instantiate(BloodVFX, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(clip, new Vector3(-9, 2, -40));
        // Destroy the GameObject this script is attached to
        Destroy(gameObject);



    }
}
