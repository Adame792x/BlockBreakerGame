using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {


    [SerializeField] Ball gameBall;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameBall.ResetAfterFall();
        // SceneManager.LoadScene("Victory");
    }

}
