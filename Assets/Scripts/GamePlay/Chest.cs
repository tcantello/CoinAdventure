using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
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
        GameManager.instance.score = GameManager.instance.score + 50;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}
