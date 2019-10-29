using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes_Laberinto : MonoBehaviour
{
    //Hola
    public enum typePared
    {
        PARED = 1,
        PARED_HOYO = 2,
        SIN_PARED = 0
    }

    public typePared myType;
    public GameObject[] paredes;

    [ContextMenu("Update The Piece")]
    public void UpdtaePiece()
    {
        foreach (GameObject g in paredes)
        {
            g.SetActive(false);
        }
        paredes[(int)myType].SetActive(true);
    }

    public void OnValidate()
    {
        UpdtaePiece();
    }
}
