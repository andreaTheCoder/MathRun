using System.Collections;
using Mono.Cecil;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    [SerializeField]
    public enum operations
    {
        multiply,
        add,
        divide,
        subtract,
    };
    public int range = 10;
    public const int NUMBEROFOPERATIONS = 4;
    operations LeftGateOp;
    operations RightGateOp;
    int RightGateNum;
    int LeftGateNum;
    [SerializeField]
    TextMeshPro RightGateText;
    [SerializeField]
    TextMeshPro LeftGateText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeftGateOp = (operations)Random.Range(0, NUMBEROFOPERATIONS + 1);
        RightGateOp = (operations)Random.Range(0, NUMBEROFOPERATIONS + 1);
        LeftGateNum = Random.Range(1, range + 1);
        RightGateNum = Random.Range(1, range + 1);
        LeftGateText.text = numberFormator(LeftGateOp, LeftGateNum);
        RightGateText.text = numberFormator(RightGateOp, RightGateNum);
    }

    // Update is called once per frame
    void Update()
    {

    }
    string numberFormator(operations operation, int num)
    {
        string formattedString = "";
        if (operation == operations.add)
            formattedString += "+";
        else if (operation == operations.subtract)
            formattedString += "-";
        else if (operation == operations.multiply)
            formattedString += "*";
        else if (operation == operations.divide)
            formattedString += "÷";
        formattedString += num.ToString();
        Debug.Log(formattedString);
        return formattedString;
    }
}
