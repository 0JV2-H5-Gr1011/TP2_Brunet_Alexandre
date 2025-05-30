using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Minuteur3Minutes : MonoBehaviour
{
    public float tempsRestant = 180f;
    public bool minuterEnCours = false;
    public TextMeshProUGUI texteMinuteur;
    public GameObject uiAfficher;
    public string sceneCharger;

    void Start()
    {
        minuterEnCours = true;
        if (uiAfficher != null)
            uiAfficher.SetActive(false);
        MettreAJourTexte(tempsRestant);
    }

    void Update()
    {
        if (minuterEnCours)
        {
            tempsRestant -= Time.deltaTime;

            if (tempsRestant <= 0)
            {
                tempsRestant = 0;
                minuterEnCours = false;
                MettreAJourTexte(tempsRestant);
                FinMinuteur();
            }
            else
            {
                MettreAJourTexte(tempsRestant);
            }
        }
    }

    void MettreAJourTexte(float temps)
    {
        if (texteMinuteur == null) return;
        float minutes = Mathf.FloorToInt(temps / 60);
        float secondes = Mathf.FloorToInt(temps % 60);
        texteMinuteur.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }

    void FinMinuteur()
    {
        if (uiAfficher != null)
            uiAfficher.SetActive(true);

        Invoke("ChangerScene", 3f);
    }

    void ChangerScene()
    {
        if (!string.IsNullOrEmpty(sceneCharger))
            SceneManager.LoadScene(sceneCharger);
    }
}
