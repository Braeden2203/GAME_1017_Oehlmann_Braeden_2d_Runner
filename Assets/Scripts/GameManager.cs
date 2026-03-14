using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button StartButton;

    [SerializeField] Button ReplayButton;
    [SerializeField] Button MenuButton;
    [SerializeField] TMP_Text GameOverText;

    

    public GameObject Player;
    public GameObject Ground;
    public GameObject Spike;

    public float GameTimer = 0;
    [SerializeField] TMP_Text GameTimerText;
    

    Vector2 PlayerSpawnPoint = new Vector2(-3, -3);
    Vector2 GroundSpawnPointStart = new Vector2(0, -4);

    public bool GamePlay = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this);

        StartButton.gameObject.SetActive(true);
        StartButton.onClick.AddListener(StartGame);

        ReplayButton.gameObject.SetActive(false);
        ReplayButton.onClick.AddListener(StartGame);
        MenuButton.gameObject.SetActive(false);
        MenuButton.onClick.AddListener(OnMenuClick);
        GameOverText.gameObject.SetActive(false);
        GameTimerText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePlay != false)
        {
            GameTimer += Time.deltaTime;
            int GameTimerRounded = Mathf.RoundToInt(GameTimer);
            GameTimerText.text = GameTimerRounded.ToString();
        }
        
    }

   

    public void StartGame()
    {
        
        SceneManager.LoadScene(1);

        GameTimer = 0;
        GameTimerText.gameObject.SetActive(true);
        GamePlay = true;
        
        
        StartButton.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(false);
        MenuButton.gameObject.SetActive(false);
        ReplayButton.gameObject.SetActive(false);

    }



    private void OnMenuClick()
    {
        SceneManager.LoadScene(0);
        

        GameOverText.gameObject.SetActive(false);
        MenuButton.gameObject.SetActive(false);
        ReplayButton.gameObject.SetActive(false);
        GameTimerText.gameObject.SetActive(false);
        StartButton.gameObject.SetActive(true);
    }

    public void Die()
    {
        
        SceneManager.LoadScene(2);
        GamePlay = false;
        

        GameOverText.gameObject.SetActive(true);
        MenuButton.gameObject.SetActive(true);
        ReplayButton.gameObject.SetActive(true);
    }
}
