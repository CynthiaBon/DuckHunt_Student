using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleAnimator : MonoBehaviour
{
    [Header("Durations")]
    [SerializeField] private float _explosionDuration = 0.0f;
    [SerializeField] private AnimationCurve _explosionCurve = null;

    [SerializeField] private float _travelDuration = 0.0f;
    [SerializeField] private AnimationCurve _travelCurve = null;

    [Header("Particles")]
    [SerializeField] private int _featherAmount = 0;
    [SerializeField] private float _explosionRadius = 0;
    [SerializeField] private float _arcSize = 0;

    [Header("Setup")]
    [SerializeField] private Transform _featherPrefab = null;

    //Particles
    private List<Transform> _feathers = null;
    private List<Vector3> _feathersExplosionPoints = null;
    private List<Vector3> _feathersMidPoints = null;
    private Vector3 _objectiveBarLocalPosition = Vector3.zero;

    //Timer
    private float _featherAnimationTimer = 0.0f;

    #region Initialization

    /// <summary>
    /// 
    /// </summary>
    /// <param name="feathersTarget"></param>
    /// <param name="canvas"></param>
    public void Initialize(Image feathersTarget, Transform canvas)
    {
    }

    #endregion Initialization

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
    private void UpdateFeatherAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateExplosionAnimation()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    private void UpdateTravelAnimation()
    {
    }

    #endregion Update
}
