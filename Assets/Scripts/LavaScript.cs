using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public GameObject newObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinScript.coinCounter++;
            Destroy(other.gameObject);

        }
        else if (CoinScript.coinCounter != 3 && other.gameObject.CompareTag("Lava"))
        {
            //gameObject.transform.position = new Vector3(-9, -2, -4);
            Movimiento.isAlive = false;
            Destroy(gameObject);
        }

    }

}
