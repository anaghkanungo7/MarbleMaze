using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string levelName = "Scene2";

    private void OnTriggerEnter(Collider other) {
        // if (other.tag == "Player") {
        //     print("Player hit");
        // }

        if (other.CompareTag("Player")) {
            // print("Player hit");
            SceneManager.LoadScene(levelName);
        }
    }


}
