using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToGameScene()
    {
        // ゲーム画面シーンに遷移
        SceneManager.LoadScene("CityScene");
    }
}
