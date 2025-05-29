using UnityEngine;
using UnityEngine.UI;

public class CurseurVolume : MonoBehaviour
{
    public AudioSource son;
    public Slider curseur;

    void Start()
    {
        if (curseur != null && son != null)
        {
            curseur.value = son.volume;
            curseur.onValueChanged.AddListener(ChangerVolume);
        }
    }

    void ChangerVolume(float valeur)
    {
        if (son != null)
        {
            son.volume = valeur;
        }
    }
}
