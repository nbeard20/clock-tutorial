using UnityEngine;
using System.Collections;
using System;

public class Clock : MonoBehaviour {

	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;

	void Update () 
	{
		DateTime time = DateTime.Now;
		int seconds = time.Second;
		float seconds_normalized = seconds / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;


		Vector3 secondsRotation = new Vector3 (0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler(secondsRotation);
		secondHand.transform.rotation = secondsRotationQuat;

		int minutes = time.Minute;
		float minutes_normalized = minutes / 60f;
		float minutes_degrees = minutes_normalized * 360f;
		float clockwise_minutes = 360f - minutes_degrees;


		Vector3 minutesRotation = new Vector3 (0f, 0f, clockwise_minutes);
		Quaternion minutesRotationQuat = Quaternion.Euler(minutesRotation);
		minuteHand.transform.rotation = minutesRotationQuat;

		int hours = time.Hour;
		float hours_normalized = hours / 12f;
		float hours_degrees = hours_normalized * 360f;
		float clockwise_hours = 360f - hours_degrees;


		Vector3 hoursRotation = new Vector3 (0f, 0f, clockwise_hours);
		Quaternion hoursRotationQuat = Quaternion.Euler(hoursRotation);
		hourHand.transform.rotation = hoursRotationQuat;

	}

}
