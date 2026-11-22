using System;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private float interactDistance;
    [SerializeField] private GameObject player; 

    void Update()
    {
        for(int i = 0; i < sparrows.Length; i++)
        {
            if(Vector3.Distance(sparrows[i].transform.position, player.transform.position) <= interactDistance)
            {
                sparrows[i].SetActive(true);
            }
            // else
            // {
            //     sparrows[i].SetActive(false);
            // }
        }
    }
}