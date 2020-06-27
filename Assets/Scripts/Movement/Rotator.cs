﻿using UnityEngine;

// Скрипт просто вращает любой объект по выбранным осям
public class Rotator : MonoBehaviour
{
    [Range(-1.0f, 1.0f)]
    private float xForceDirection = 0.0f;
    [Range(-1.0f, 1.0f)]
    private float yForceDirection = 0.0f;
    [Range(-1.0f, 1.0f)]
    private float zForceDirection = 0.0f;

    public float speedMultiplier = 1;

    public bool worldPivote = false;

    private Space spacePivot = Space.Self;

    public float XForceDirection { get { return xForceDirection; } set { xForceDirection = value; }}
    public float YForceDirection { get { return yForceDirection; } set { yForceDirection = value; }}
    public float ZForceDirection { get { return zForceDirection; } set { zForceDirection = value; }}

    void Start()
    {
        if (worldPivote) spacePivot = Space.World;
    }

    void Update()
    {
        this.transform.Rotate(xForceDirection * speedMultiplier, yForceDirection * speedMultiplier, zForceDirection * speedMultiplier, spacePivot);
    }

}