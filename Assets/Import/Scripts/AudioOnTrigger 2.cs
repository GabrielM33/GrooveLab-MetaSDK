using System.Collections.Generic;
using UnityEngine;

public class AudioOnTrigger : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTrigger(Collider other)
    {   
        Debug.Log("Trigger entered!");
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Trigger entered by object with tag: " + other.tag);
            source.PlayOneShot(clip);
        }

        if (other.CompareTag(targetTag))
        {
            Debug.Log("Playing sound: " + clip.name);
            source.PlayOneShot(clip);
            Debug.Log("Sound played!");

        }
    }
}
