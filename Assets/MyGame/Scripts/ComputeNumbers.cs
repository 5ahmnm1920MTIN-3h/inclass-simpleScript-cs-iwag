using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    // Start is called before the first frame update
    void Start()
    {
        varA = 5;
        varB = 4;
        SubstractNumbers(varA, varB);
        SubstractNumbers(4, 7);
        Debug.Log("in Start: " + SubstractNumbers(varA, varB));
        Debug.Log("in Start: " + SubstractNumbers(4, 7));
        Debug.Log(10 - SubstractNumbers(varA, varB));
        Debug.Log(100 - SubstractNumbers(4, 7));
        SetResult();
    }

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult" + (a - b));
       // result.text = SubstractNumbers(a,b);
    }

    public string TestMethode()
    {
        Debug.Log("Test");
        return "Test";
    }
    public void TestMethodeVOID()
    {
        Debug.Log("Test");
    }
    public float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        //Debug.Log("Test sub" + result.ToString());
        return result;
    }
    public float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        //Debug.Log("Test sub" + result.ToString());
        return result;
    }
    // Update is called once per frame
    void Update()
    {

    }
}