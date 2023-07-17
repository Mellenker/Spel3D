using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderAI : MonoBehaviour
{
    [SerializeField] private Transform dest1, dest2, dest3, dest4;
    [SerializeField] private int numberOfDestinations = 4;

    [SerializeField] private Transform player;

    [SerializeField] private float teleportRate;
    bool teleporting = true;
    int randNum;

    private void Start()
    {
        StartCoroutine(teleport());
    }

    private void Update()
    {
        this.transform.LookAt(new Vector3(player.position.x, this.transform.position.y, player.position.z));
    }

    IEnumerator teleport()
    {
        while(teleporting = true)
        {
            yield return new WaitForSeconds(teleportRate);
            randNum = Random.Range(0, numberOfDestinations);
            switch (randNum)
            {
                case 0: 
                    this.transform.position = dest1.position; 
                    break;
                case 1:
                    this.transform.position = dest2.position;
                    break;
                case 2:
                    this.transform.position = dest3.position;
                    break;
                case 3:
                    this.transform.position = dest4.position;
                    break;
            }
        }

    }
}
