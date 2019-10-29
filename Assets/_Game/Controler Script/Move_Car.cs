using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Car : MonoBehaviour
{
    public enum typeButtom
    {
        Up,
        Right,
        Down,
        Left
    }

    public typeButtom myType;
    public Grid mapa;
    public GameObject character;

    void OnMouseDown()
    {
        Debug.Log("Me estan dando click " + gameObject.name);
        if(myType == typeButtom.Up)
        {
            character.transform.localPosition = mapa.CellToLocal(mapa.WorldToCell(character.transform.position) + new Vector3Int(0, 0, 1));
        }
        if (myType == typeButtom.Right)
        {
            character.transform.localPosition = mapa.CellToLocal(mapa.WorldToCell(character.transform.position) + new Vector3Int(1, 0, 0));
        }
        if (myType == typeButtom.Down)
        {
            character.transform.localPosition = mapa.CellToLocal(mapa.WorldToCell(character.transform.position) + new Vector3Int(0, 0, -1));
        }
        if (myType == typeButtom.Left)
        {
            character.transform.localPosition = mapa.CellToLocal(mapa.WorldToCell(character.transform.position) + new Vector3Int(-1, 0, 0));
        }
    }
}
