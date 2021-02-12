using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ManagerEnnemysScript : MonoBehaviour
{
    [SerializeField] GameObject PrefabRobot;
    [SerializeField] float rayon = 10f, delay = 0.5f, rangeY = 5f;
    public GameObject[] positions;
    public bool v=false;
    void Start()
    {
        InvokeRepeating("Generation", 0f, delay);
    } 
    // Répéter la fonction Generation d’une manière régulière 
    // Après N secondes (ici 0), avec une fréquence = delay
 void Generation()
    {
        if (!v)
        {
            int angle = Random.Range(1, 360);
            Vector3 pos = Vector3.zero;
            pos.x = transform.position.x + rayon * Mathf.Cos(angle);
            pos.z = transform.position.z + rayon * Mathf.Sin(angle);
            pos.y = Random.Range(-rangeY, rangeY);
            GameObject go = Instantiate(PrefabRobot, pos, Quaternion.identity);
        }
        else
        {
            Transform tr = positions[Random.Range(0, positions.Length-1)].transform;
            GameObject go = Instantiate(PrefabRobot, tr.position, Quaternion.identity);
        }
      
    }
}
