using UnityEngine;
using System.Collections;

public class AbScoreBase : TrnthMonoBehaviour {
	public UILabel labelScore;
	public int score;
	public void scoreApply(){
		score+=1;
		if(labelScore)labelScore.text=score+"";
	}
}
