using UnityEngine;
using System.Collections;

public class AbControllerQuestion : AbScoreBase {
	public UILabel label;
	public string buttonPrefix;
	public void update(){
		int[] ints=new int[]{Random.Range(0,5),Random.Range(0,6)};
		label.text=ints[0]+"+"+ints[1]+"=?";
		_answer=ints[0]+ints[1];
		
	}
	public void answer(int value){
		if(value==_answer){
			scoreApply();
		}
		update();
	}
	int _answer;
	void Start(){
		update();
	}
	void button(int number){
		if(Input.GetButtonDown(buttonPrefix+number)){
			answer(number);
		}
	}
	void Update(){
		for(var i=0;i<9;i+=1){
			button(i);			
		}
	}
}
