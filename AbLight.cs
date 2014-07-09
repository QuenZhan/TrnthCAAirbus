using UnityEngine;
using System.Collections;

public class AbLight : MonoBehaviour {
	public TweenColor tc;
	public string input;
	public bool isOn;
	public void lightOn(){
		isOn=true;
		tc.PlayForward();
	}
	public void lightOff(){
		isOn=false;
		tc.ResetToBeginning();
		tc.enabled=false;
	}
}
