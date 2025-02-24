using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1
public class CombatManager : BaseManager
{
    // 2
    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }
    // 3
    public override void Initialize()
    {
        _state = "Combat Manager initialized..";
        Debug.Log(_state);
    }
}
