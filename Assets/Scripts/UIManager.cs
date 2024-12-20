using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private ObjectiveBar _objectiveBar = null;
    [SerializeField] private Image _feathersTarget = null;
    [SerializeField] private PostProcessAnimator _postProcessAnimator = null;
    [SerializeField] private ParticleAnimator _particleAnimatorPrefab = null;
    [SerializeField] private VictoryScreen _victoryScreen = null;

    #region Feedback

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ratio"></param>
    /// <param name="increase"></param>
    /// <param name="target"></param>
    public void SetObjectiveRatio(float ratio, bool increase, Transform target)
    {
        _objectiveBar.SetRatio(ratio, increase);
    }

    /// <summary>
    /// 
    /// </summary>
    public void ShowVictoryScreen()
    {
        _victoryScreen.Show();
    }

    #endregion Feedback
}
