using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ParameterAsset", menuName = "ScriptableObjects/ParameterAsset")]
public class ParameterAsset : ScriptableObject
{
    public List<Parameter> ParameterList = new();
}

[System.Serializable]
public class Parameter
{
    public EntityIdentifier Id;
    public string Name;
    public int Hp;
    public int Atk;
    public Texture2D Icon;

    internal object FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
