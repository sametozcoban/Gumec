using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    [SerializeField] [Range(0f, 5f)] float speed = 1f;

    Enemy _enemy;
    // Start is called before the first frame update
    void OnEnable()
    {
        PathRotate();
        ReturnToStart();
        StartCoroutine(FollowingPath());
    }

    void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    void PathRotate()
    {
        path.Clear();
        
        GameObject [] waypoints = GameObject.FindGameObjectsWithTag("Path");

        foreach (GameObject waypoint in waypoints)
        {
            path.Add(waypoint.GetComponent<WayPoint>());
        }
    }

    void ReturnToStart()
    {
        transform.position = path[0].transform.position;
    }

    IEnumerator FollowingPath()
    {
        foreach (WayPoint wayPoint in path)
        {
            Vector3 starPosition = transform.position;
            Vector3 endPosition = wayPoint.transform.position;
            float timeLEPS = 0f;
            transform.LookAt(endPosition);

            while (timeLEPS < 1f)
            {
                timeLEPS += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(starPosition, endPosition, timeLEPS);
                yield return new WaitForEndOfFrame();
            }
        }
        _enemy.GoldPenalty();
        gameObject.SetActive(false);
    }
}
