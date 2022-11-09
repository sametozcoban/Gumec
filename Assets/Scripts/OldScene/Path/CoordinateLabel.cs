using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]
public class CoordinateLabel : MonoBehaviour
{
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.blue;
    
    TextMeshPro _textMeshPro;
    Vector2Int _vector2Int = new Vector2Int();

    WayPoint _wayPoint;
   void Awake()
    {
        _textMeshPro = GetComponent<TextMeshPro>();
        _wayPoint = GetComponentInParent<WayPoint>();
        _textMeshPro.enabled = false;
        DisplayCoordinates();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UptadeObjectName();
        }
        
        SetLabelColor();
        ToggleCoordinates();

    }
    
    void DisplayCoordinates()
    {
        _vector2Int.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        _vector2Int.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        _textMeshPro.text = _vector2Int.x + "," +  _vector2Int.y;
    }

    void UptadeObjectName()
    {
        transform.parent.name = _vector2Int.ToString();
    }

    void SetLabelColor()
    {
        if (_wayPoint.IsPlaceable)
        {
             _textMeshPro.color= defaultColor;
        }
        else
        {
            _textMeshPro.color = blockedColor;
        }
    }

    void ToggleCoordinates()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _textMeshPro.enabled = !_textMeshPro.IsActive();
        }
    }
}
