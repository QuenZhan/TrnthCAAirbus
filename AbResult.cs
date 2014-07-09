using UnityEngine;
using System.Collections;

public class AbResult : MonoBehaviour {
	public AbResultRow prefabRow;
	public UITable table;
	public void execute(AbModelScore[] scores){
		foreach(Transform e in table.transform){Destroy(e.gameObject);}
		var th=Instantiate(prefabRow) as AbResultRow;
		append(th.transform);
		foreach(var e in scores){
			var row=Instantiate(prefabRow) as AbResultRow;
			append(row.transform);
			row.score=e;
			row.execute();
		}
		table.Reposition();
	}
	void append(Transform tra){
		tra.parent=table.transform;
		tra.localScale=Vector3.one;
	}

}
