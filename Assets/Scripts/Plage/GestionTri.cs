using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GestionTri : MonoBehaviour
{
    public static GestionTri instance;
    public UnityEvent toutEstFait;

    private static int binsComplete = 0;
    private static bool nourritureFini = false;
    private static bool cartonFini = false;
    private static bool verreFini = false;

    void Awake()
    {
        instance = this;
    }

    public static void AjouterSiTermine(string tag)
    {
        if (tag == "Nourriture" && !nourritureFini)
        {
            nourritureFini = true;
            binsComplete += 1;
        }
        else if (tag == "Carton" && !cartonFini)
        {
            cartonFini = true;
            binsComplete += 1;
        }
        else if (tag == "Verre" && !verreFini)
        {
            verreFini = true;
            binsComplete += 1;
        }

        if (binsComplete == 3 && instance)
        {
            instance.toutEstFait.Invoke();
            instance.ChangerScene();
        }
    }

    void ChangerScene()
    {
        SceneManager.LoadScene("SceneFinale");
    }
}
