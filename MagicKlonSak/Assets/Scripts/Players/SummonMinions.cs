using UnityEngine;
using System.Collections;

public class SummonMinions : MonoBehaviour {
	public Transform prefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Summon ();
		}
	}

	public void Summon()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray,out hit)&& hit.transform.tag =="Mark")
			Instantiate(prefab, new Vector3(hit.point.x,(hit.point.y+0.5f),hit.point.z), transform.rotation);
	}
}
