using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button StartButton;

    [SerializeField] Button ReplayButton;
    [SerializeField] Button MenuButton;
    [SerializeField] TMP_Text GameOverText;

    public GameObject Player;
    public GameObject Ground;
    public GameObject Spike;

    

    Vector2 PlayerSpawnPoint = new Vector2(-3, -3);
    
    

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        StartButton.gameObject.SetActive(true);
        StartButton.onClick.AddListener(StartGame);

        
        //Player.SetActive(false);
        Ground.SetActive(false);
        Spike.SetActive(false);

        ReplayButton.gameObject.SetActive(false);
        ReplayButton.onClick.AddListener(StartGame);
        MenuButton.gameObject.SetActive(false);
        MenuButton.onClick.AddListener(OnMenuClick);
        GameOverText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);

        

        
        Instantiate(Player, PlayerSpawnPoint, Quaternion.identity);
        
        
        Ground.SetActive(true);
        Spike.SetActive(true);

        GameOverText.gameObject.SetActive(false);
        MenuButton.gameObject.SetActive(false);
        ReplayButton.gameObject.SetActive(false);

    }



    private void OnMenuClick()
    {
        Ground.SetActive(false);
        Spike.SetActive(false);

        GameOverText.gameObject.SetActive(false);
        MenuButton.gameObject.SetActive(false);
        ReplayButton.gameObject.SetActive(false);

        StartButton.gameObject.SetActive(true);
    }

    public void Die()
    {
        //Debug.Log("B");


        Ground.SetActive(false);
        Spike.SetActive(false);

        GameOverText.gameObject.SetActive(true);
        MenuButton.gameObject.SetActive(true);
        ReplayButton.gameObject.SetActive(true);
    }
}
