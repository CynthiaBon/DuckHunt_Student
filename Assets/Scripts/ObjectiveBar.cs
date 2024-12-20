using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveBar : MonoBehaviour
{
    [Header("Shake")]
    [SerializeField] private float _shakeIntensity = 0.0f;
    [SerializeField] private float _shakeDuration = 0.0f;
    [SerializeField] private AnimationCurve _shakeCurve = null;

    [Header("Bar")]
    [SerializeField] private float _increaseDuration = 0.0f;
    [SerializeField] private float _increaseDelay = 0.0f;
    [SerializeField] private float _decreaseDuration = 0.0f;

    [Header("Color")]
    [SerializeField] private Gradient _fillGradient = null;

    [Header("Setup")]
    [SerializeField] private Image _bar = null;

    //Durations
    private float _ratioUpdateDuration = -1.0f;

    //Timers
    private float _ratioTimer = 0.0f;
    private float _shakeTimer = 0.0f;

    //Ratio
    private float _currentRatio = 0.0f;
    private float _targetRatio = 0.0f;

    //States
    private bool _updateRatio = false;
    private bool _playShake = false;

    //Memory
    private Vector3 _barPosition = Vector3.zero;

    #region Initialization

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
    }

    #endregion Initialization

    #region Triggers

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ratio"></param>
    /// <param name="increase"></param>
    public void SetRatio(float ratio, bool increase)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void StartShake()
    {
    }

    #endregion Triggers

    #region Update

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateRatio()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateShake()
    {
    }

    #endregion Update
}
