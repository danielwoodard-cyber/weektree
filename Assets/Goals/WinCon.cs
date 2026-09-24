using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    public float winDistance = 2f;

        public bool hasWon = false;

    void start()
        {
            
        }
    
        void Update()
        {

        if (hasWon) return;
        
        float distance = Vector3.Distance(player.position, goal.position);
            Debug.Log(distance);
        
        if (distance <= winDistance)
        {
            Debug.Log("close enough");
            hasWon = true;
            WinGame();
        }
        
        }

    void WinGame()
    {
        Debug.Log("You Win!");
        SceneManager.LoadScene("win screen");
    }
}
