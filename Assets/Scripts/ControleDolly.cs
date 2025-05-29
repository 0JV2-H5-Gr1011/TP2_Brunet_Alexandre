using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using StarterAssets;
using System.Collections;

public class ControleDolly : MonoBehaviour
{
    public CinemachineVirtualCamera camVirtuelle;
    public float prioriteSeuil = 10f;
    public CanvasGroup[] interfacesUI;
    public StarterAssetsInputs entreeJoueur;
    public float vitesseFade = 1f;
    public AudioSource sourceAudio;
    public AudioClip sonDolly;
    public Transform cibleRegard;

    bool enDolly = false;
    float cibleAlpha = 0f;

    void Start()
    {
        cibleAlpha = 0f;
        foreach (var ui in interfacesUI)
        {
            ui.alpha = 0f;
            ui.interactable = false;
            ui.blocksRaycasts = false;
        }
    }

    void Update()
    {
        bool active = camVirtuelle.Priority >= prioriteSeuil;

        if (active && !enDolly)
        {
            enDolly = true;
            entreeJoueur.enabled = false;
            cibleAlpha = 0f;
            if (sourceAudio != null && sonDolly != null) StartCoroutine(JouerSonAvecDelai());
        }
        else if (!active && enDolly)
        {
            enDolly = false;
            entreeJoueur.enabled = true;
            cibleAlpha = 1f;
        }

        if (enDolly && cibleRegard != null)
        {
            Vector3 direction = transform.position - cibleRegard.position;
            Quaternion cibleRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, cibleRotation, Time.deltaTime * 1.5f);
        }

        foreach (var ui in interfacesUI)
        {
            ui.alpha = Mathf.MoveTowards(ui.alpha, cibleAlpha, vitesseFade * Time.deltaTime);
            ui.interactable = ui.alpha > 0.9f;
            ui.blocksRaycasts = ui.alpha > 0.9f;
        }
    }

    IEnumerator JouerSonAvecDelai()
    {
        yield return new WaitForSeconds(3f);
        sourceAudio.PlayOneShot(sonDolly);
    }
}
