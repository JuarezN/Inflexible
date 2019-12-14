using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
  public Cell Cell;
  public Transform SideCellPosition;
  public void OnTriggerEnter(Collider other)
  {
    if (Cell != null || other.transform.parent.parent.name == "Cluster")
      return;
    var cell = other.GetComponentInParent<Cell>();
    Cell = cell;
    cell.transform.position = SideCellPosition.position;
    cell.transform.SetParent(transform.parent.parent);
  }
}
