using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public int S = 0;
    public int R = 1;

    int BRANCH (int a)
    {

    }

    int AND (int a,int b)
    {
        return a * b;
    }

    int OR (int a, int b)
    {
        return a + b;
    }

    int NOT (int a)
    {
        if (a == 0)
            return 1;
        else
            return 0;
    }

    int NAND (int a, int b)
    {
        return NOT(AND(a, b));
    }

    int NOR (int a, int b)
    {
        return NOT(OR(a, b));
    }

    int XOR (int a, int b)
    {
        if (a == b)
            return 0;
        else
            return 1;
    }

    void Function(int num,int a,int b)
    {
        switch (num)
        {
            case 1:
                AND(a, b);
                break;
            case 2:
                OR(a, b);
                break;
            case 3:
                NOT(a);
                break;
            case 4:
                NAND(a, b);
                break;
            case 5:
                NOR(a, b);
                break;
            case 6:
                XOR(a, b);
                break;
        }    
    }
}
