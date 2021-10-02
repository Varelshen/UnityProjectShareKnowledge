using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosConteo : MonoBehaviour
{

    int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            ScoreScriptBrac.ScoreRecolected += 1;
            puntos = puntos + 1;
            Debug.Log("punto");
            Destroy(gameObject);

        }
    }
}
