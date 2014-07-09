using UnityEngine;
using System.Collections;

public class AbResultRow : MonoBehaviour {
	public AbModelScore score;
	public	UILabel lName;
	public	UILabel lMain;
	public	UILabel lLeft;
	public	UILabel lLights;
	public	UILabel lCaculate;
	public void execute(){
		if(score==null)return;
		lName.text=score.name;
		lMain.text=score.main+"";
		lLeft.text=score.left+"";
		lLights.text=score.light+"";
		lCaculate.text=score.caculate+"";
	}
}
