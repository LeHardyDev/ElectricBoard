using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Types : MonoBehaviour
{
    public enum TileTypes
    {
        Empty,
        Start,
        Goal,
        Block,
        StaticConducter,
        PlayerConducter,
        Button,
        Gate,
        Detonator,
        BreakableBlock
    }
}
