using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Header("Game parameters")]
    [SerializeField] private int _score = 0;

    [Header("Movement")]
    [SerializeField] private float _movementDuration = 0.0f;
    [SerializeField] private float _oscillationAmplitude = 0.0f;
    [SerializeField] private float _oscillationLength = 0.0f;

    [Header("Setup")]
    [SerializeField] private TargetAnimator _targetAnimator = null;

    //Movement
    private float _movementTimer = 0.0f;
    private bool _canMove = true;

    private Transform _startPoint = null;
    private Transform _endPoint = null;

    //Components
    private GameManager _gameManager = null;

    #region Initialization

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="gameManager"></param>
    public void Initialize(Transform start, Transform end, GameManager gameManager)
    {
    }

    #endregion Initialization

    #region Movement

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void Move()
    {
    }

    #endregion Movement

    #region Interactions

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseEnter()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseExit()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void Hit()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int GetScore()
    {
        return _score;
    }

    #endregion Interactions
}
