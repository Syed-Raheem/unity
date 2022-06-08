using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private GameObject sphere;

    [SerializeField]
    private GameObject cylinder;

    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private GameObject _sphere;
    [SerializeField]
    private GameObject _cylinder;

    private Renderer cubeRenderer;
    private Renderer sphereRenderer;
    private Renderer cylinderRenderer;

    [SerializeField]
    private Toggle myobject1  , myobject2 , myobject3;

    [SerializeField]
    private GameObject myobject11,myobject21,myobject31;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = _cube.GetComponent<Renderer>();
        sphereRenderer = _sphere.GetComponent<Renderer>();
        cylinderRenderer = _cylinder.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callCube()
    {
        // float x;
        // float y;
        // float z;
        // Vector3 pos;
        // x = Random.Range(-3,8);
        // y = Random.Range(-2.8f, 3.78f);
        // z = 0;
        // pos = new Vector3(x, y, z);
        // Instantiate(cube, pos, Quaternion.identity);
        //int randomi = Random.Range(0,cube.Length);
        Vector3 rand=new Vector3(Random.Range(200,670),Random.Range(50,270),0);
        Instantiate(cube,rand,Quaternion.identity);
        //cubeA.Add(yy);
        myobject11.SetActive(true);
        

    }
    public void Sphere()
    {
        // float x;
        // float y;
        // float z;
        // Vector3 pos;
        // x = Random.Range(-3, 8);
        // y = Random.Range(-2.8f, 3.78f);
        // z = 0;
        // pos = new Vector3(x, y, z);
        // Instantiate(sphere, pos, Quaternion.identity);
        Vector3 rand=new Vector3(Random.Range(200,670),Random.Range(50,270),0);
        Instantiate(sphere,rand,Quaternion.identity);
        //sphereA.Add(y);
        myobject21.SetActive(true);
    }
    public void Cylinder()
    {
        // float x;
        // float y;
        // float z;
        // Vector3 pos;
        // x = Random.Range(-3, 8);
        // y = Random.Range(-2.8f, 3.78f);
        // z = 0;
        // pos = new Vector3(x, y, z);
        // Instantiate(cylinder, pos, Quaternion.identity);
        Vector3 rand=new Vector3(Random.Range(200,670),Random.Range(50,270),0);
        Instantiate(cylinder,rand,Quaternion.identity);
       // cylinderA.Add(x);
        myobject31.SetActive(true);
    }
    public void SetCubeColor()
    {
        if (myobject1.isOn)
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.black);
        }
        else
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.red);
        }
    }
    public void SetCylinderColor()
    {
        if (myobject3.isOn)
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.black);
        }
        else
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.blue);
        }
    }

    public void SetSphereColor()
    {
        if (myobject2.isOn)
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.black);
        }
        else
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.green);
        }

    }
}
