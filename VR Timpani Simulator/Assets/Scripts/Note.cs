using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Note : MonoBehaviour
{
    private int NoteIndex;
    private float NoteTime;
    private int NoteType;
    private string NoteExtra;

    public Note(int noteIndex, float noteTime, int noteType, string noteExtra)
    {
        NoteIndex = noteIndex;
        NoteTime = noteTime;
        NoteType = noteType;
        NoteExtra = noteExtra;
    }
}
