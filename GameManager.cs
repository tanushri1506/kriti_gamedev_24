using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isLevelCompleted;
    public GameObject gameOverScreen;
    public GameObject NextScreen;
    private void Awake(){
        isGameOver = false;
        isLevelCompleted = false; 
    }
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver){
            gameOverScreen.SetActive(true);
        }

        if(isLevelCompleted){
            NextScreen.SetActive(true);
        }
    }

    public void ReplayLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
