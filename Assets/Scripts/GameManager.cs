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

    Vector2 PlayerSpawnPoint = new Vector3(-3, -3);
    Vector2 GroundSpawnPoint = new Vector2(0, -4);
    Vector2 SpikeSpawnPoint = new Vector2(-3, 0);
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartButton.gameObject.SetActive(true);
        StartButton.onClick.AddListener(StartGame);


        //Player.SetActive(false);
       // Ground.SetActive(false);
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

   

    private void StartGame()
    {
        StartButton.gameObject.SetActive(false);

        Instantiate(Ground, GroundSpawnPoint, Quaternion.identity);
        Instantiate(Player, PlayerSpawnPoint, Quaternion.identity);
        
        
        //Player.SetActive(true);
        //Ground.SetActive(true);
        Spike.SetActive(true);

       // Player.gameObject.transform.Translate(-3, -2.8f, 0);
       // Ground.gameObject.transform.Translate(0, 0, 0);
       // Spike.gameObject.transform.Translate(0, 0, 0);
    }

    private void OnMenuClick()
    {

    }

    public void Die()
    {
        Debug.Log("B");
        
        Destroy(Ground);
        Destroy(Player);
       
        Spike.SetActive(false);

        GameOverText.gameObject.SetActive(true);
        MenuButton.gameObject.SetActive(true);
        ReplayButton.gameObject.SetActive(true);
    }
}
