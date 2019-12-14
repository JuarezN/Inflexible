using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  [SerializeField]
  private PivotController _pivotController;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
    {
      _pivotController.Turn(90);
    }

    if (Input.GetKeyDown(KeyCode.D))
    {
      _pivotController.Turn(-90);
    }

    if (Input.GetKeyDown(KeyCode.W))
    {
      _pivotController.ChangePivot(true);
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
      _pivotController.ChangePivot(false);
    }
  }
}
