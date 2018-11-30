﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour {

    public GameObject triangleObject;
    public GameObject triangleObjectBorder;
    MeshGenerator meshGeneratorTriangle;
    MeshGenerator meshGeneratorBorder;
    int enemyTriangle;

    void Start() {
        UpdateTriangle();
    }

    public int GetNumber() {
        return enemyTriangle;
    }

    public void UpdateTriangle() {
        int idx = Random.Range(0, TriangleHelper.availableTriangles.Length);
        enemyTriangle = TriangleHelper.availableTriangles[idx];
        meshGeneratorTriangle = triangleObject.GetComponent<MeshGenerator>();
        meshGeneratorBorder = triangleObjectBorder.GetComponent<MeshGenerator>();
        SetTriangle();
    }

    public void SetTriangle() {
        switch (enemyTriangle) {
            case 1:
                meshGeneratorTriangle.SetValues(2, 1); //Equilateral Triangle
                meshGeneratorBorder.SetValues(2.2f, 1.2f);
                break;
            case 2:
                meshGeneratorTriangle.SetValues(4, 1); //Isosceles Triangle
                meshGeneratorBorder.SetValues(4.2f, 1.2f);
                break;
            case 3:
                meshGeneratorTriangle.SetValues(2, 3); //Scalene Triangle
                meshGeneratorBorder.SetValues(2.2f, 3.5f);
                break;
            default:
                break;
        }
    }
}
