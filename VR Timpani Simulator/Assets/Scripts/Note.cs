using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Note : MonoBehaviour
{
    private int NoteID;
    private float Time;
    private string NotePitch;
    private string NoteType;
    private string NoteExtra;

    public Note(int noteID, float time, string notePitch, string noteType, string noteExtra)
    {
        NoteID = noteID;
        Time = time;
        NotePitch = notePitch;
        NoteType = noteType;
        NoteExtra = noteExtra;
    }
}
