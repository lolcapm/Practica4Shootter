using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ComportamientoDisparo : MonoBehaviour {

	// Use this for initialization
	public  float velDisparo = 25;
	public float meDistaciaposi;
	public float meDistacianega;
	public Transform explosion;
	public static int desexplotion;
	public static float puntos;
	public static int contador;
	//public Transform explosionPosition;

	void Start () {
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * velDisparo * Time.deltaTime);
		if (transform.position.z >= meDistaciaposi) {
			Destroy (this.gameObject);
		}
		if (transform.position.z <= meDistacianega) {
			Destroy (this.gameObject);
		}
		if (transform.position.x >= meDistaciaposi) {
			Destroy (this.gameObject);
		}
		if (transform.position.x <= meDistacianega) {
			Destroy (this.gameObject);
		}
		if (transform.position.y >= meDistaciaposi) {
			Destroy (this.gameObject);
		}
		if (transform.position.y <= meDistacianega) {
			Destroy (this.gameObject);
		}
		desexplotion = 0;

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "ObjetoADestruir1") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
			desexplotion = 1;
			contador += 1;
			puntos += 3.448275862068966f;
			puntos = Mathf.Round (puntos);
		}
        if (other.gameObject.tag == "Paredes")
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            desexplotion = 1;
            contador += 1;
            puntos += 3.448275862068966f;
            puntos = Mathf.Round(puntos);
        }
    }
}