using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake () {
		hoursPivot.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * DateTime.Now.Hour);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * DateTime.Now.Minute);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * DateTime.Now.Second);
	}

}
