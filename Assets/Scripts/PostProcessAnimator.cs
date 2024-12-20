using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessAnimator : MonoBehaviour
{
    [Header("Duration")]
    [SerializeField] private float _bombEffectDuration = 0.0f;
    [SerializeField] private AnimationCurve _bombEffectCurve = null;

    [Header("Post process")]
    [SerializeField] private float _maxIntensity = 0.0f;

    //Timer
    private float _bombEffectTimer = 0.0f;

    //State
    private bool _playBombEffect = false;

    //Post process
    private Vignette _vignette;
    private ChromaticAberration  _chromaticAberration;

    #region Initialization

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
    }

    #endregion Initialization

    #region Trigger

    /// <summary>
    /// 
    /// </summary>
    public void playBombEffect()
    {
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
    private void UpdateBombEffect()
    {
    }

    #endregion Update
}
