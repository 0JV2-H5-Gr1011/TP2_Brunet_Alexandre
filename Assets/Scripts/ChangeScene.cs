using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChargerScene(string nomScene)
    {
        SceneManager.LoadScene(nomScene);
    }
}
