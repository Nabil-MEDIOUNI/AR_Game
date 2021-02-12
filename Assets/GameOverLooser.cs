using UnityEngine;
public class GameOverLooser : MonoBehaviour
{
    public GameObject GameOver;
    public int hp = 5;
    public GameObject[] hps;
   /* void OnCollisionEnter(Collision collision)
    { 
        GameOver.SetActive(true);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        hp--;
        if (hp >= 0)
        {
            hps[hp].SetActive(false);
            Debug.Log(hp);
            
            if (hp == 0)
            {
                GameOver.SetActive(true);
            }
        }
      
        
       
        
    }
}