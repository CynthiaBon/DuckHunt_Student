using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAnimator : MonoBehaviour
{
    [Header("Durations")]
    [SerializeField] private float _targetAnimationDuration = 0.0f;
    [SerializeField] private AnimationCurve _targetAnimationCurve = null;

    [SerializeField] private float _hitAnimationDuration = 0.0f;
    [SerializeField] private AnimationCurve _hitAnimationCurve = null;

    [Header("Color")]
    [SerializeField] private Gradient _hitGradient = null;

    [Header("Setup")]
    [SerializeField] private SpriteRenderer _targetRenderer = null;
    [SerializeField] private ParticleSystem _hitParticles = null;

    //Timers
    private float _targetTimer = 0.0f;
    private float _hitTimer = 0.0f;

    //States
    private bool _playTargetAnimation = false;
    private bool _playHitAnimation = false;

    //Animations
    private Animator _animator = null;


    #region Initialization

    private void Awake()
    {
        _animator = _targetRenderer.GetComponent<Animator>();
    }

    #endregion Initialization

    #region Triggers

    /// <summary>
    /// 
    /// </summary>
    public void PlayTargetAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void StopTargetAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void PlayHitAnimation()
    {
        _animator.SetTrigger("Death");
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
    private void UpdateTargetSpawnAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateTargetDispawnAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateHitAnimation()
    {
    }

    #endregion Update
}
