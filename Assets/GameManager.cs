using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Score = 0;
    private bool GameOver = false;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject GameOver_Text;
    [SerializeField] private Text Score_Text;
    [SerializeField] private Shoot shoot;
    

    public void GameOverMethod()
    {
        if (!GameOver)
        {
            mainCamera.GetComponent<Animator>().SetBool("GameIsOver", true);
            GameOver_Text.SetActive(true);
            shoot.enabled = false;
            Invoke("Restart", 3f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        Score_Text.text = Score.ToString();
    }

}
