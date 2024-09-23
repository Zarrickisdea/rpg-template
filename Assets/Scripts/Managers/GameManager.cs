using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerScriptableObject playerScriptableObject;

    [SerializeField]
    private List<EnemyScriptableObject> enemyScriptableObjects;

    private PlayerFactory playerFactory;
    private EnemyFactory enemyFactory;

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

        playerFactory = new PlayerFactory();
        enemyFactory = new EnemyFactory();
    }

    private void Start()
    {
        SpawnPlayer();
        SpawnEnemies();
    }

    private void SpawnPlayer()
    {
        playerFactory.CreateEntity(playerScriptableObject);
    }

    private void SpawnEnemies()
    {
        foreach (EnemyScriptableObject enemyScriptableObject in enemyScriptableObjects)
        {
            enemyFactory.CreateEntity(enemyScriptableObject);
        }
    }
}