using UnityEngine;
using System.Collections;

public class DestroyExplotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	IEnumerator TimeOfDestroyExplotion(){
		for (float f = 1f; f >= 0; f -= 0.2f) {
			yield return new WaitForSeconds (0.2f);

		}
		Destroy (this.gameObject);
	}
	void Update () {
		if (ComportamientoDisparo.desexplotion == 1) {
			StartCoroutine ("TimeOfDestroyExplotion");

		}
	}
}
