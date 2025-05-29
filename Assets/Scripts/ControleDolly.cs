using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class ControleDolly : MonoBehaviour
{
    public CinemachineVirtualCamera camVirtuelle;
    public float prioriteSeuil = 10f;
    public CanvasGroup[] interfacesUI;
    public CharacterController controleur;
    public float vitesseFade = 1f;

    bool enDolly = false;
    float cibleAlpha = 1f;

    void Update()
    {
        bool active = camVirtuelle.Priority >= prioriteSeuil;

        if (active && !enDolly)
        {
            enDolly = true;
            controleur.enabled = false;
            cibleAlpha = 0f;
        }
        else if (!active && enDolly)
        {
            enDolly = false;
            controleur.enabled = true;
            cibleAlpha = 1f;
        }

        foreach (var ui in interfacesUI)
        {
            ui.alpha = Mathf.MoveTowards(ui.alpha, cibleAlpha, vitesseFade * Time.deltaTime);
            ui.interactable = ui.alpha > 0.9f;
            ui.blocksRaycasts = ui.alpha > 0.9f;
        }
    }
}
