using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string GTBremark;
    public string HPTCCVremark;
    public string Tubeblankremark;
    public string Tankcapremark;
    public string B1Flangeremark1;
    public string TAIADremark1;
    public string ALTremark1;
    public string OTBremark1;
    public string Serialnumber;
    public string Jobnumber;

    public CharacterData(Character character)
    {
        GTBremark = character.GTBremark;
        HPTCCVremark = character.HPTCCVremark;
        Tubeblankremark = character.Tubeblankremark;
        Tankcapremark = character.Tankcapremark;
        B1Flangeremark1 = character.B1Flangeremark;
        TAIADremark1 = character.TAIADremark;
        ALTremark1 = character.ALTremark;
        OTBremark1 = character.OTBremark;
        Serialnumber = character.Serialnumber;
        Jobnumber = character.Jobnumber;
    }
}
