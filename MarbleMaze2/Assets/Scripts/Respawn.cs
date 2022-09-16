using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public string levelName = "Level2";

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
