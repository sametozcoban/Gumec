using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
   [SerializeField] Target towerPrefab;
   [SerializeField] bool isPlaceable;
   
   public bool IsPlaceable { get { return isPlaceable; } }
   void OnMouseDown()
   {
      if (isPlaceable)
      {
         bool isPlaced = towerPrefab.CreateTarget(towerPrefab, transform.position);
         isPlaceable = !isPlaced;
      }
      
   }
}
