using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class AffichageVolume : MonoBehaviour
{
    public StarterAssetsInputs controles;
    bool actif = false;

    void Update()
    {
        if (Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            actif = !actif;
            GameObject[] volumes = GameObject.FindGameObjectsWithTag("Volume");
            foreach (GameObject v in volumes)
                v.SetActive(actif);

            controles.cursorLocked = !actif;
            controles.cursorInputForLook = !actif;
            Cursor.lockState = actif ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = actif;
        }
    }
}
