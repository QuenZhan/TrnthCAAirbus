using UnityEngine;
using System.Collections.Generic;
using TRNTH;
public class AbControllerLights : AbScoreBase {
	public GameObject lights;
	public float cooldown;
	public float cooldownNoise;	
	public GameObject select;
	public GameObject[] onCorrect;
	public GameObject[] onWrong;
	public void report(string name){
		if(select&&select.name==name){
			activate(onCorrect);
			scoreApply();
		}
		else activate(onWrong);
		select=null;
		foreach(var e in _lights){
			e.lightOff();			
		}
		CancelInvoke();
		Invoke("execute",cooldown+Random.value*cooldownNoise);
	}
	AbLight[] _lights;
	void beClick(int number){
		var yes=Input.GetButtonDown("Light"+number);
		if(!yes)return;		
		report("Light"+number);
		
	}
	void execute(){
		var tra=U.chooseChild(lights.transform);
		var light=tra.GetComponent<AbLight>();
		light.lightOn();
		select=light.gameObject;
		Invoke("timeup",5);
	}
	void timeup(){
		report("");
	}
	void Start(){
		var list=new List<AbLight>();
		foreach(Transform e in lights.transform){
			var light=e.GetComponent<AbLight>();
			list.Add(light);
		}
		_lights=list.ToArray();
		Invoke("execute",cooldown+Random.value*cooldownNoise);
	}
	void Update(){
		beClick(1);
		beClick(2);
		beClick(3);
		beClick(4);
	}

}