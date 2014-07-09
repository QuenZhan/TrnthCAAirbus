using UnityEngine;
using System.Collections;

public class AbLocatorForcer : AbScoreBase {
	public GameObject target;
	public Rigidbody2D rig;
	public float force=1;
	public float noise;
	void Start(){
		rig.AddForce(Vector2.right*10);
	}
	void FixedUpdate(){
		var vec=target.transform.position-transform.position;
		rig.AddForce((vec.normalized+Random.insideUnitSphere*noise)*force);
	}
	void OnTriggerStay2D(Collider2D col){
		//Debug.Log(col.name);
		if(col.gameObject.tag!="Center")return;
		scoreApply();
	}
}
