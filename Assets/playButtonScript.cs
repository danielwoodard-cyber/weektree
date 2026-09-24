using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playButtonScript : MonoBehaviour
{
    public Button playButton;
    void Start()
    {
       if (playButton != null)
        {
            playButton.onClick.AddListener(OnButtonClick);
        }
    }

    
    void OnButtonClick()
    {
        SceneManager.LoadScene("daniel maze");
    }
}
