using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game parameters")]
    [SerializeField] private int _targetScore = 0;
    [SerializeField] private Vector2 _spawnRateRange = Vector2.zero;
    [SerializeField] private float _bombSpawnRate = 0.0f;

    [Header("Setup")]
    [SerializeField] private Target _duckPrefab = null;
    [SerializeField] private Target _bombPrefab = null;
    [SerializeField] private UIManager _uiManager = null;
    [SerializeField] private List<Transform> _spawnPoints = null;
    [SerializeField] private List<Transform> _endPoints = null;

    [Header("Debug")]
    [SerializeField] private bool _enableCheat = false;

    //Score
    private int _currentScore = 0;

    //Spawn
    private float _spawnTimer = 0.0f;
    private float _currentSpawnRate = 0.0f;
    private bool _canSpawn = true;

    //Interactions
    private Target _cachedTarget = null;

    #region Initialization

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
    }

    #endregion Initialization

    #region GameLoop

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void SpawnManagement()
    {
    }

    private void SpawnTarget()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void SetSpawnRate()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void EndGame()
    {
        _canSpawn = false;
        _uiManager.ShowVictoryScreen();
    }

    #endregion GameLoop

    #region Interactions

    /// <summary>
    /// 
    /// </summary>
    private void InputManagement()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void AddScore()
    {
        int scoreToAdd = _cachedTarget.GetScore();

        _currentScore += scoreToAdd;
        if (_currentScore < 0)
        {
            _currentScore = 0;
        }
        else if (_currentScore >= _targetScore)
        {
            _currentScore = _targetScore;
            EndGame();
        }

        _uiManager.SetObjectiveRatio((float)_currentScore / (float)_targetScore, scoreToAdd > 0, _cachedTarget.transform);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    public void CacheTarget(Target target)
    {
        _cachedTarget = target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    public void TryEmtyCache(Target target)
    {
        if (_cachedTarget == target)
            _cachedTarget = null;
    }

    #endregion Interactions
}
