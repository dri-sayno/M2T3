using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scri : MonoBehaviour {
    Rigidbody _rigidBody;
    Transform _transform;

    // Use this for initialization
    void Start() {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        ProcessInput();
    }
    private void ProcessInput(){

        if(Input.GetKey(KeyCode.Space)){
            _rigidBody.AddRelativeForce(Vector3.up * 45 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 100 * Time.deltaTime);  
            print("Rotate Left");   
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 100 * Time.deltaTime);
            print("Rotate Right"); 
        }
    }

    void OnCollisionEnter(Collision col){
        if ((col.gameObject.name != "Launchpad") && (col.gameObject.name != "Target Pad"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
