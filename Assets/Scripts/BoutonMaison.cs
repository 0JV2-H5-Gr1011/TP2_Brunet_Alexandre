using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonMaison : MonoBehaviour
{
    public void GoToMaison()
    {
        SceneManager.LoadScene("Maison");
    }
}
