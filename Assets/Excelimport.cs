using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MstItemEntity
{
    public int x;
    public int y0;    
    public int y1;
    public int y2;
    public int y3;
    public int y4;
    public int y5;
    public int y6;
    public int y7;
    public int y8;
    public int y9;
    public int y10;
    public int y11;
    public int y12;
    public int y13;
    public int y14;
    public int y15;
    public int y16;
    public int y17;
    public int y18;
    public int y19;
    public int y20;
    public int y21;
    public int y22;
    public int y23;
    public int y24;
    public int y25;
    public int y26;
    public int y27;
    public int y28;
    public int y29;
    public int y30;
    public int y31;
    public int y32;
    public int y33;
    public int y34;
    public int y35;
    public int y36;
    public int y37;
    public int y38;
    public int y39;
    public int y40;
    public int y41;
    public int y42;
    public int y43;
    public int y44;
    
    public int callvar(string varname)
    {
        System.Reflection.FieldInfo variable = this.GetType().GetField(varname);
        int y = System.Convert.ToInt32(variable.GetValue(this));
        return y;
    }

}