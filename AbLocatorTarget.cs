using UnityEngine;
using System.Collections;

public class AbLocatorTarget : AbScoreBase {
	public string inputH;
	public string inputV;
	void Update(){
		var h=Input.GetAxis(inputH);
		var v=Input.GetAxis(inputV);
		var vec=new Vector3(h,-v,0);
		tra.localPosition=(vec*20);
	}
}
