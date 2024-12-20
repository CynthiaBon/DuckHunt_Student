using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScreen : MonoBehaviour
{
    [Header("Duration")]
    [SerializeField] private float _animationDuration = 0.0f;

    [Header("Background")]
    [SerializeField] private AnimationCurve _fadeInCurve = null;
    [SerializeField] private float _targetOpacity = 0.0f;

    [Header("Victory")]
    [SerializeField] private AnimationCurve _spinCurve = null;
    [SerializeField] private AnimationCurve _scaleCurve = null;

    [Header("Setup")]
    [SerializeField] private Image _victoryText = null;
    [SerializeField] private Image _background = null;
    [SerializeField] private ParticleSystem _victoryParticles = null;

    //Timer
    private float _animationTimer = 0.0f;

    //State
    private bool _playAnimation = false;

    #region Trigger

    /// <summary>
    /// 
    /// </summary>
    public void Show()
    {
        _victoryText.enabled = true;
        _background.enabled = true;
    }

    #endregion Trigger

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
    private void UpdateAnimation()
    {
    }

    #endregion Update
}
