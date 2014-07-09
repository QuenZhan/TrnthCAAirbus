using UnityEngine;
using System.Collections.Generic;

public class AbScoreSaver : MonoBehaviour {
	public AbScoreBase main;
	public AbScoreBase left;
	public AbScoreBase lights;
	public AbScoreBase caculate;
	public AbResult result;
	public void execute(){
		var score=new AbModelScore();
		scores.Add(score);
		score.name="Level "+(scores.Count);
		score.main=main.score;
		score.left=left.score;
		score.light=lights.score;
		score.caculate=caculate.score;
		Debug.Log(score);
		output();
		reset();
	}
	public void reset(){
		main.score=0;
		left.score=0;
		lights.score=0;
		caculate.score=0;
	}
	public void output(){
		result.execute(scores.ToArray());
	}
	List<AbModelScore> scores=new List<AbModelScore>();
}
