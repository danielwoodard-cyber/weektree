using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitButtonScript : MonoBehaviour
{
    public Button exitButton;
    void Start()
    {
       if (exitButton != null)
        {
            exitButton.onClick.AddListener(OnButtonClick);
        }
    }

    
    void OnButtonClick()
    {
        Application.Quit();
    }
}
