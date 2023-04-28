using System;
using UnityEngine;

/// <summary>
/// отй╬ндвж
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class LableTextAttribute : PropertyAttribute
{
    public string DisplayName;

    public LableTextAttribute(string displayName)
    {
        DisplayName = displayName;
    }
}
