using UnityEngine;
using System.Collections;

public class AbLevelForcer : AbScoreBase {
	public UIProgressBar bar;
	public float force;
	public float noise;
	public float drag=0.97f;
	public string input;
	float velocity;
	void Update(){
		var f=Input.GetAxis(input);
		//Debug.Log(f);
		velocity+=force*(f+(Random.value-Random.value)*noise);
		velocity*=drag;
		bar.value+=velocity;
		if(bar.value<0.55
			&&bar.value>0.45)scoreApply();
	}
}
