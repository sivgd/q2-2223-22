using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    //-------------------------------------------------------------------
    //--dont bother asking me what all of this does, even I am clueless--
    //-------------------------------------------------------------------

    [Header("Time")]
    [Tooltip("Day Length(minutes)")]
    [SerializeField]
    private float _targetDayLength = 6f; // length of day in minutes.
    public float targetDayLength
    {
        get
        {
            return _targetDayLength;
        }

    }
    [SerializeField]
    [Range(0f, 1f)]
    private float _timeOfDay;
    public float timeOfDay
    {
        get
        {
            return _timeOfDay;
        }
    }
    [SerializeField]
    private int _dayNumber = 0; //how many days have pased since you last chose to stop eating at taco bell
    public int dayNumber
    {

        get
        {
            return _dayNumber;
        }

    }
    [SerializeField]
    private int _yearNumber = 0;
    public int yearNumber
    {
        get
        {
            return _yearNumber;
        }

    }
    private float _Timescale = 100f;
    [SerializeField]
    private int _yearLength = 100;
    public float yearlength
    {
        get
        {
            return _yearLength;
        }

    }
    public bool pause = false; //time is simply a construct, but it is a construct that I can bend to my will...

    [Header("Sun Light")]
    [SerializeField]
    private Transform dailyRotation;



    private void Update()
    {
        if (!pause)
        {
            UpdateTimeScale();
            UpdateTimer();

        }
        AdjustSunRotation();

    }


    private void UpdateTimeScale()
    {
        _Timescale = 24 / (_targetDayLength / 60);
    }

    private void UpdateTimer()
    {
        _timeOfDay += Time.deltaTime * _Timescale / 86400; // did you know there is 86,400 seconds in a day, now you know
        if (_timeOfDay > 1) // new day just dropped, wheres the patch notes?
        {
            _dayNumber++;
            _timeOfDay -= 1;

            if (_dayNumber > _yearLength) // did you know the lego movie was released 9 years ago
            {

                _yearNumber++;
                _dayNumber = 0;

            }

        }
    }

    //sun rotate
    private void AdjustSunRotation()
    {
        float sunAngle = timeOfDay * 360f;
        dailyRotation.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, sunAngle));
    }



}
