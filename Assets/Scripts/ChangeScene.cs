using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    public void ChargerScene(string nomScene)
    {
        SceneManager.LoadScene(nomScene);
    }
}
