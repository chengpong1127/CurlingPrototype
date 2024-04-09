using UnityEngine;
using UnityEngine.Events;


public class CurlingFieldController: MonoBehaviour{
    public UnityEvent<double> OnBallStopAtFirstCircle;
    public UnityEvent<double> OnBallStopAtSecondCircle;
}