using UnityEngine;
using UnityEngine.Rendering;

public class ControleDollySimple : MonoBehaviour
{
    public MonoBehaviour entreeJoueur;
    public Canvas[] interfacesUI;
    public Volume volumeGlobal;
    public Animator animDolly;
    public string nomAnimation = "DollyMove";

    public void DemarrerDolly()
    {
        entreeJoueur.enabled = false;
        foreach (var ui in interfacesUI) ui.enabled = false;
        volumeGlobal.enabled = true;
        animDolly.Play(nomAnimation, 0, 0);
        StartCoroutine(AttendreFin());
    }

    System.Collections.IEnumerator AttendreFin()
    {
        while (animDolly.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;

        entreeJoueur.enabled = true;
        foreach (var ui in interfacesUI) ui.enabled = true;
        volumeGlobal.enabled = false;
    }
}
