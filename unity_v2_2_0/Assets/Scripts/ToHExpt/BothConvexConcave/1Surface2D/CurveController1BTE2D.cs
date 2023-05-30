using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]

public class CurveController1BTE2D : MonoBehaviour
{
    private Manager1BTE2D _manager;

    Vector3 planeYZ;

    float delay;    
    float halfCurveLength;
    float curveHeightDepth;
    float curveRadius;

    //public GameObject Curve;
    float width = 0.004f; //Width of Curve

    //flag
    bool flagVideoConvex = true;

    //for discover change
    float previousDelay = 0f;
    float previousCurveHeightDepth=0f;
    bool previousFlagVideoConvex = true;

    // Start is called before the first frame update
    void Start()
    {
        _manager = GameObject.Find("Manager").GetComponent<Manager1BTE2D>();

        planeYZ = _manager.PlaneYZ;

        delay = _manager.Delay;
        halfCurveLength = _manager.HalfCurveLength;
        curveHeightDepth = _manager.CurveHeightDepth;
        curveRadius = _manager.CurveRadius;

    }

    // Update is called once per frame
    void Update()
    {
        delay = _manager.Delay;
        halfCurveLength = _manager.HalfCurveLength;
        curveHeightDepth = _manager.CurveHeightDepth;
        curveRadius = _manager.CurveRadius;
        flagVideoConvex = _manager.FlagVideoConvex;

        if ((previousDelay != delay) || (previousCurveHeightDepth != curveHeightDepth) || (previousFlagVideoConvex != flagVideoConvex))
        {
            if (flagVideoConvex)
            {
                CreateConvex();
            }
            else
            {
                CreateConvene();
            }

            previousDelay = delay;
            previousCurveHeightDepth = curveHeightDepth;
            previousFlagVideoConvex = flagVideoConvex;
        }
    }

    int reverseAngle = 0; //�����v���ł݂��Ƃ��̃X�^�[�g�n�_�̊p�x�i�x�j
    int startAngle = 0;  //�X�^�[�g�n�_�̊p�x�i�x�j
    int areaAngle = 0;  //�쐬����p�x�i�x�j

    int quality = 100;     //180deg�̂Ƃ���triangle��
    //bool isOutward = true; //���������O������ //Outward -> convex, Inward -> concave

    Vector3 pos; //�ʒu

    private Vector3[] vertices; //���_
    private int[] triangles;    //index

    private void CreateConvex()
    {
        startAngle = (int)(Mathf.Atan2(Mathf.Abs(curveRadius - curveHeightDepth), halfCurveLength) * Mathf.Rad2Deg);
        areaAngle = 180 - 2 * startAngle;

        //Make Parameters
        List<Vector3> vertList = new List<Vector3>();
        List<int> triList = new List<int>();

        //Cylinder
        float th, v1, v2;
        int max = quality * areaAngle / 180;
        for (int i = 0; i <= max; i++)
        {
            th = i * areaAngle / max + startAngle;
            v1 = Mathf.Sin(th * Mathf.Deg2Rad);
            v2 = Mathf.Cos(th * Mathf.Deg2Rad);
            vertList.Add(new Vector3(v2 * (curveRadius - width), v1 * (curveRadius - width), 0) + planeYZ);
            vertList.Add(new Vector3(v2 * curveRadius, v1 * curveRadius, 0) + planeYZ);

            if (i <= max - 1)
            {
                triList.Add(2 * i); triList.Add(2 * i + 3); triList.Add(2 * i + 1);
                triList.Add(2 * i); triList.Add(2 * i + 2); triList.Add(2 * i + 3);
            }
        }

        vertices = vertList.ToArray();
        triangles = triList.ToArray();

        //Set Parameters
        Mesh mesh = new Mesh();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // �@���ƃo�E���f�B���O�̌v�Z
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        mesh.name = "CurveMesh";
        //transform.localScale = scale;

        //Change Height(Depth) from planeYZ
        pos = this.transform.position;
        pos.y = curveHeightDepth - curveRadius;
        this.transform.position = pos;

        GetComponent<MeshFilter>().sharedMesh = mesh;
        // �F�w��
        GetComponent<MeshRenderer>().material.color = new Color32(255, 162, 162, 255); //pink
    }


    private void CreateConvene()
    {
        reverseAngle = (int)(Mathf.Atan2(Mathf.Abs(curveRadius - curveHeightDepth), halfCurveLength) * Mathf.Rad2Deg);
        startAngle = 180 + reverseAngle;
        areaAngle = 180 - 2 * reverseAngle;

        //Make Parameters
        List<Vector3> vertList = new List<Vector3>();
        List<int> triList = new List<int>();

        //Cylinder
        float th, v1, v2;
        int max = quality * areaAngle / 180;
        for (int i = 0; i <= max; i++)
        {
            th = i * areaAngle / max + startAngle;
            v1 = Mathf.Sin(th * Mathf.Deg2Rad);
            v2 = Mathf.Cos(th * Mathf.Deg2Rad);
            vertList.Add(new Vector3(v2 * curveRadius, v1 * curveRadius, 0) + planeYZ);
            vertList.Add(new Vector3(v2 * (curveRadius + width), v1 * (curveRadius + width), 0) + planeYZ);

            if (i <= max - 1)
            {
                triList.Add(2 * i + 3); triList.Add(2 * i + 1); triList.Add(2 * i);
                triList.Add(2 * i + 3); triList.Add(2 * i); triList.Add(2 * i + 2);
            }

        }

        vertices = vertList.ToArray();
        triangles = triList.ToArray();

        //Set Parameters
        Mesh mesh = new Mesh();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // �@���ƃo�E���f�B���O�̌v�Z
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        mesh.name = "CurveMesh";
        //transform.localScale = scale;

        //Change Height(Depth) from planeYZ
        pos = this.transform.position;
        pos.y = curveRadius - curveHeightDepth;
        this.transform.position = pos;

        GetComponent<MeshFilter>().sharedMesh = mesh;
        // �F�w��
        GetComponent<MeshRenderer>().material.color = new Color32(255, 162, 162, 255); //pink
    }

}

//Cylinder //https://blog.narumium.net/2016/11/21/unity-c-%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88%E3%81%A7%E5%86%86%E5%BC%A7%E3%81%A8%E7%AD%92%E3%82%92%E4%BD%9C%E6%88%90%E3%81%99%E3%82%8B/
//Plane(by Rectangular) //https://www.ame-name.com/archives/8312
