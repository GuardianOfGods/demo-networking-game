using System;
using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;

    public float MinX;
    public float MaxX;
    public float MinZ;
    public float MaxZ;

    public void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(MinX,MaxX),0,Random.Range(MinZ,MaxZ));
        PhotonNetwork.Instantiate(PlayerPrefab.name, randomPos, Quaternion.identity);
    }
}
