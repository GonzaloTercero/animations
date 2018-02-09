using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeMeshAgent : MonoBehaviour {
	[SerializeField]
	Transform location;
	NavMeshAgent iaAgent;

	Vector3 initPosition;
	Vector3 secondPosition;
	Vector3 actualWayPoint;
 	// Use this for initialization
	void Awake () {
		initPosition = this.transform.position;
		secondPosition = this.initPosition + new Vector3 (10.0f, 0.0f, 8.0f);
		actualWayPoint = secondPosition;

		iaAgent = GetComponent<NavMeshAgent> ();
		iaAgent.SetDestination (actualWayPoint);
	}

	void Update(){
		Debug.Log (Vector3.Distance(actualWayPoint, this.transform.position));
		if(Vector3.Distance(actualWayPoint, this.transform.position) < 1.0f){
			UpdateActualWayPoint ();
		}
	}

	void UpdateActualWayPoint(){
		if (actualWayPoint == initPosition) {
			actualWayPoint = secondPosition;
		} else {
			actualWayPoint = initPosition;
		}
		iaAgent.SetDestination (actualWayPoint);
	}


}
