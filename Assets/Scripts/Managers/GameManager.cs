using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerScriptableObject playerScriptableObject;

    [SerializeField]
    private List<EnemyScriptableObject> enemyScriptableObjects;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        SpawnPlayer();
        SpawnEnemy();
    }

    private void SpawnPlayer()
    {
        PlayerView playerView = playerScriptableObject.EntityObject as PlayerView;
        if (playerView != null)
        {
            PlayerController playerController = new PlayerController();
            PlayerModel playerModel = new PlayerModel();
            Instantiate(playerView);
            playerController.InitController();
        }
    }

    private void SpawnEnemy()
    {
        foreach (EnemyScriptableObject enemyScriptableObject in enemyScriptableObjects)
        {
            EnemyView enemyView = enemyScriptableObject.EntityObject as EnemyView;
            Instantiate(enemyView);
        }
    }
}
