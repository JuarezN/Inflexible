using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotController : MonoBehaviour
{
  [SerializeField]
  private Cell _pivot;
  [SerializeField]
  private GameObject _cells;
  private int _rotationCount;

  public void Turn(float amount)
  {
    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + amount);
    if (amount > 0)
    {
      _rotationCount++;
    }
    else
    {
        _rotationCount--;
    }
  }

  public void ChangePivot(bool up)
  {
    int r = 0;
    if (up)
    {
      r = Mathf.Abs(_rotationCount) % 4;
    }
    else
    {
      r = (Mathf.Abs(_rotationCount) + 2) % 4;
    }
    Debug.Log(r + " "+ Mathf.Abs(_rotationCount));
    if (up)
    {
      if (_pivot.Joints[r].Cell != null && _pivot.Joints[r].Cell != null)
      {
        _cells.transform.position = _cells.transform.position - _pivot.Joints[r].Cell.transform.position;
        _pivot = _pivot.Joints[r].Cell;
      }
      else
      {
        Debug.Log("Algo null");
      }
    }
    else
    {
      if (_pivot.Joints[r].Cell != null && _pivot.Joints[r].Cell != null)
      {
        _cells.transform.position = _cells.transform.position - _pivot.Joints[r].Cell.transform.position;
        _pivot = _pivot.Joints[r].Cell;
      }
      else
      {
        Debug.Log("Algo null");
      }
    }
  }
}
