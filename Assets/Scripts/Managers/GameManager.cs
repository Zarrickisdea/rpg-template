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
            var attributeList = new AttributeCollection(playerScriptableObject.AttributeObjects);
            var parameterList = new ParameterCollection(playerScriptableObject.ParameterObjects);
            PlayerModel playerModel = new PlayerModel(playerController, attributeList, parameterList);
            var playerGameObject = Instantiate(playerView);
            playerController.InitController(playerGameObject, playerModel);
        }
    }

    private void SpawnEnemy()
    {
        foreach (EnemyScriptableObject enemyScriptableObject in enemyScriptableObjects)
        {
            EnemyView enemyView = enemyScriptableObject.EntityObject as EnemyView;
            if (enemyView != null)
            {
                EnemyController enemyController = new EnemyController();
                var attributeList = new AttributeCollection(enemyScriptableObject.AttributeObjects);
                var parameterList = new ParameterCollection(enemyScriptableObject.ParameterObjects);
                EnemyModel enemyModel = new EnemyModel(enemyController, attributeList, parameterList);
                var enemyGameObject = Instantiate(enemyView);
                enemyController.InitController(enemyGameObject, enemyModel);
            }
        }
    }
}
