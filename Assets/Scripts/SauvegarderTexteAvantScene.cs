using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SauvegarderTexteAvantScene : MonoBehaviour
{
    public TMP_InputField champTexte;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SauvegarderEtChangerScene(string nomScene)
    {
        TexteSauvegarde.texte = champTexte.text;
        SceneManager.LoadScene(nomScene);
    }
}
