using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeurDeScene : MonoBehaviour
{
    [SerializeField] private string sceneSelectionnee;
    [SerializeField] private string sceneMenu;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == sceneSelectionnee)
        {
            SceneManager.LoadScene(sceneMenu, LoadSceneMode.Additive);
        }
    }
}
