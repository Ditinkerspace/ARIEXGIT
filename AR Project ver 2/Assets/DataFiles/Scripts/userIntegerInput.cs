using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class userIntegerInput : MonoBehaviour
{
    // public InputField userID;
    // public TextMeshProUGUI user_Id_Display;

    
    public InputField ratingInput;
    public int RatingPrefab;
    public string user_Id_Input;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void checkUserIdInput()
    {
        user_Id_Input = ratingInput.text;

        string input3 = user_Id_Input;

        int.TryParse(input3, out int result);

        Debug.Log(result);
        RatingPrefab = int.Parse(ratingInput.ToString());
        Debug.Log(RatingPrefab);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // autofill part name and reference no.

    /*

    // Part number           Part name            
    
    340-050-704-0            Transfer Gearbox (TGB) done 

    340-046-503-0            Accessory Gearbox (AGB) done

    1853M56P07/ P09          Hydro-Mech. Unit(HMU) <does this means two part number with same name or this is just one part number> done
    1853M56P09/ P10

    340-402-104-0            Main Fuel Pump (MFP) done
    (828300-4)

    340-400-004-0            Lubrication Unit done 

    301-789-101-0            Servo Fuel Heater done 
    (45731-1382)

    301-780-702-0            Main Oil/Fuel Heat Exchanger done 
    (11-841193-2)

    340-402-301-0            T25 Sensor (CIT) done
    (RP236-00)

    340-400-303-0            Oil Scavenge Filter done
    (41F9003)

    FA00631B                 Fuel Nozzle Filter done

    45731-1393               IDG Oil Cooler done 

    1853M48P02               Fuel Flow Transmitter done
    (8TJ167GHH1)

    320-549-002-0            N2 Speed Sensor done 

    1851M36P1                Air Starter done 
    (3505945-10)

    9387M16P02               Alternator Rotor done
    (85465-2)

    9387M17P09               Alternator Stator done 
    (87006-9)

    340-402-902-0            Oil Pressure Switch done 
    (APTE8A20007
    BARD)

    340-403-201-0            Oil Temp Probe done 
    (RP238-00)

    340-400-402-0            Oil Clogging Transmitter done 
    (QA07656 ISS 3)

    340-402-706-0            Fuel Differential Switch done
    (QA07995)

    320-862-401-0            N1 Speed Sensor done 

    144-187-000-011          Sensor, VIB-FFCC done 

    144-186-000-011          Sensor, VIB BRG 1 done 

    9238M66P08               Ignition Exciter done 
    (10-631045-2)

    340-403-802-0            Oil Tank To check if SN is in suspected lot.(Refer to Table 1) done 
    (41F5102)

    1851M33P06               Elect. Engine Control (EEC/ECU) done 

    1853M78P24               ECU Software done 

    340-402-201-0            T12 Temperature Sensor done 
    (RP235-00)

    1821M59P06               Turbine Clearance Valve (TCC) done 
    (3291186-6)

    325-035-501-0            J1 Wire Bundle done 

    325-026-901-0            J2 Wire Bundle done
    
    325-015-001-0            J3 Wire Bundle done

    325-035-201-0            J4 Wire Bundle done 

    325-034-902-0            J5 Harness Assy done 

    325-025-002-0            J6 Harness Assy done 

    325-025-702-0            J7 Harness Assy done 

    325-025-803-0            J8 Harness Assy done 

    325-043-401-0            J9 Harness Assy done 
    325-025-202-0

    325-043-501-0            J10 Harness Assy done 
    325-034-802-0

    325-027-701-0C           CJ9 Harness Assy done 

    325-102-001-0C           CJ10 Harness Assy done 
    325-025-401-0

    325-029-902-0            MW0311 Harnes done 

    325-026-701-0            MW0312 Harness done 

    325-026-801-0            MW0313 Harness done 

    325-027-303-0            MW0315 Harness done 

    325-027-403-0            MW0316 Harness done 

    325-027-505-0            MW0325 Harness done 

    325-027-605-0            MW0326 Harness done 

    340-402-003-0            LPT Clearance Control Valve (LPTCC) done 
    (C24937001-1)

    390-060-501-0            Engine ID Trim Plug (Ref SB 72-0106) done 

    1853M47P01               T3 Sensor done
    (8TC19AAN1)

    340-402-801-0            Oil Level Sensor done 
    (8TJ146CFA1)

    S332W110-2               Oil Scupper Drain Tube done 

    1821M60P02               Air Transient Bleed Valve (TBV) done 
    (3291390-1)

    1317M47G01/16            Fuel Nozzles done 

    1527M33P10               Burner Staging Selector Valve (BSV) (Optional) done 
    (44E64-8)

    340-402-503-0            T49.5 Probe done 

    1853M13P01               Igniter Lead done 
    (9059110-1)

    1374M12P01               Spark Igniter done 
    (9044035-1)

    340-402-603-0            VBV Actuator done 
    (7074-200)

    1324M12P10               VSV Actuator done 
    (1211313-010)

    1324M94P03               HPT Thermocouple done 
    (8TC19AAH1)

    340-400-203-0            Oil Anti Leak Valve done 
    (41F3003)

    AM2563-227/              Engine Stand done 
    AM2811-1100

    ============================================================================================================

    // autofill part name by keying in the part number (according to the document in the pc)

    else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-050-704-0")
            {
                Missing1PartNum.Add("340-050-704-0"); // part 1 
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-050-704-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Transfer Gearbox (TGB)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-046-503-0")
            {
                Missing1PartNum.Add("340-046-503-0"); // part 2
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-046-503-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Accessory Gearbox (AGB)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M56P07/ P09")
            {
                Missing1PartNum.Add("1853M56P07/ P09"); // part 3 (1)
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M56P07/ P09");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Hydro-Mech. Unit(HMU)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M56P09/ P10")
            {
                Missing1PartNum.Add("1853M56P09/ P10"); // part 3 (2)
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M56P09/ P10");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Hydro-Mech. Unit(HMU)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-104-0")
            {
                Missing1PartNum.Add("340-402-104-0"); // part 4
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-104-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Main Fuel Pump (MFP)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-400-004-0")
            {
                Missing1PartNum.Add("340-400-004-0"); // part 5
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-400-004-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Lubrication Unit");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "301-789-101-0")
            {
                Missing1PartNum.Add("301-789-101-0"); // part 6
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "301-789-101-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Servo Fuel Heater");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "301-780-702-0")
            {
                Missing1PartNum.Add("301-780-702-0"); // part 7
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "301-780-702-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Main Oil/Fuel Heat Exchanger");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-301-0")
            {
                Missing1PartNum.Add("340-402-301-0"); // part 8
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-301-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "T25 Sensor (CIT)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-400-303-0")
            {
                Missing1PartNum.Add("340-400-303-0"); // part 9
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-400-303-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Scavenge Filter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "FA00631B")
            {
                Missing1PartNum.Add("FA00631B"); // part 10
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "FA00631B");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Fuel Nozzle Filter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "45731-1393")
            {
                Missing1PartNum.Add("45731-1393"); // part 11
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "45731-1393");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "IDG Oil Cooler");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M48P02")
            {
                Missing1PartNum.Add("1853M48P02"); // part 12
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M48P02");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Fuel Flow Transmitter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "320-549-002-0")
            {
                Missing1PartNum.Add("320-549-002-0"); // part 13
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "320-549-002-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "N2 Speed Sensor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1851M36P1")
            {
                Missing1PartNum.Add("1851M36P1"); // part 14
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1851M36P1");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Air Starter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "9387M16P02")
            {
                Missing1PartNum.Add("9387M16P02"); // part 15
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "9387M16P02");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Alternator Rotor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "9387M17P09")
            {
                Missing1PartNum.Add("9387M17P09"); // part 16
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "9387M17P09");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Alternator Stator");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-902-0")
            {
                Missing1PartNum.Add("340-402-902-0"); // part 17
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-902-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Pressure Switch");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-403-201-0")
            {
                Missing1PartNum.Add("340-403-201-0"); // part 18
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-403-201-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Temp Probe");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-400-402-0")
            {
                Missing1PartNum.Add("340-400-402-0"); // part 19
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-400-402-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Clogging Transmitter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-706-0")
            {
                Missing1PartNum.Add("340-402-706-0"); // part 20
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-706-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Fuel Differential Switch");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "320-862-401-0")
            {
                Missing1PartNum.Add("320-862-401-0"); // part 21
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "320-862-401-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "N1 Speed Sensor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "144-187-000-011")
            {
                Missing1PartNum.Add("144-187-000-011"); // part 22
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "144-187-000-011");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Sensor, VIB-FFCC");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "144-186-000-011")
            {
                Missing1PartNum.Add("144-186-000-011"); // part 23
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "144-186-000-011");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Sensor, VIB BRG 1");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "9238M66P08")
            {
                Missing1PartNum.Add("9238M66P08"); // part 24
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "9238M66P08");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Ignition Exciter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-403-802-0")
            {
                Missing1PartNum.Add("340-403-802-0"); // part 25
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-403-802-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Tank");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1851M33P06")
            {
                Missing1PartNum.Add("1851M33P06"); // part 26
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1851M33P06");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Elect. Engine Control (EEC/ECU)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M78P24")
            {
                Missing1PartNum.Add("1853M78P24"); // part 27
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M78P24");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "ECU Software");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-201-0")
            {
                Missing1PartNum.Add("340-402-201-0"); // part 28
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-201-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "T12 Temperature Sensor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1821M59P06")
            {
                Missing1PartNum.Add("1821M59P06"); // part 29
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1821M59P06");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Turbine Clearance Valve (TCC)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-035-501-0")
            {
                Missing1PartNum.Add("325-035-501-0"); // part 30
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-035-501-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J1 Wire Bundle");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-026-901-0")
            {
                Missing1PartNum.Add("325-026-901-0"); // part 31
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-026-901-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J2 Wire Bundle");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-015-001-0")
            {
                Missing1PartNum.Add("325-015-001-0"); // part 32
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-015-001-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J3 Wire Bundle");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-035-201-0")
            {
                Missing1PartNum.Add("325-035-201-0"); // part 33
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-035-201-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J4 Wire Bundle");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-034-902-0")
            {
                Missing1PartNum.Add("325-034-902-0"); // part 34
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-034-902-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J5 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-025-002-0")
            {
                Missing1PartNum.Add("325-025-002-0"); // part 35
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-025-002-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J6 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-025-702-0")
            {
                Missing1PartNum.Add("325-025-702-0"); // part 36
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-025-702-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J7 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-025-803-0")
            {
                Missing1PartNum.Add("325-025-803-0"); // part 37
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-025-803-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J8 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-043-401-0")
            {
                Missing1PartNum.Add("325-043-401-0"); // part 38
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-043-401-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J9 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-043-501-0")
            {
                Missing1PartNum.Add("325-043-501-0"); // part 39
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-043-501-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "J10 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-027-701-0C")
            {
                Missing1PartNum.Add("325-027-701-0C"); // part 40
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-027-701-0C");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "CJ9 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-102-001-0C")
            {
                Missing1PartNum.Add("325-102-001-0C"); // part 41
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-102-001-0C");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "CJ10 Harness Assy");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-029-902-0")
            {
                Missing1PartNum.Add("325-029-902-0"); // part 42
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-029-902-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0311 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-026-701-0")
            {
                Missing1PartNum.Add("325-026-701-0"); // part 43
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-026-701-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0312 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-026-801-0")
            {
                Missing1PartNum.Add("325-026-801-0"); // part 44
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-026-801-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0313 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-027-303-0")
            {
                Missing1PartNum.Add("325-027-303-0"); // part 45
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-027-303-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0315 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-027-403-0")
            {
                Missing1PartNum.Add("325-027-403-0"); // part 46
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-027-403-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0316 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-027-505-0")
            {
                Missing1PartNum.Add("325-027-505-0"); // part 47
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-027-505-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0325 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "325-027-605-0")
            {
                Missing1PartNum.Add("325-027-605-0"); // part 48
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "325-027-605-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "MW0326 Harness");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-003-0")
            {
                Missing1PartNum.Add("340-402-003-0"); // part 49
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-003-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "LPT Clearance Control Valve (LPTCC)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "390-060-501-0")
            {
                Missing1PartNum.Add("390-060-501-0"); // part 50
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "390-060-501-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Engine ID Trim Plug (Ref SB 72-0106)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M47P01")
            {
                Missing1PartNum.Add("1853M47P01"); // part 51
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M47P01");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "T3 Sensor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-801-0")
            {
                Missing1PartNum.Add("340-402-801-0"); // part 52
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-801-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Level Sensor");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "S332W110-2")
            {
                Missing1PartNum.Add("S332W110-2"); // part 53
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "S332W110-2");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Scupper Drain Tube");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1821M60P02")
            {
                Missing1PartNum.Add("1821M60P02"); // part 54
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1821M60P02");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Air Transient Bleed Valve (TBV)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1317M47G01/16")
            {
                Missing1PartNum.Add(" 1317M47G01/16"); // part 55
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, " 1317M47G01/16");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Fuel Nozzles");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1527M33P10")
            {
                Missing1PartNum.Add("1527M33P10"); // part 56
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1527M33P10");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Burner Staging Selector Valve (BSV)");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-503-0")
            {
                Missing1PartNum.Add("340-402-503-0"); // part 57
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-503-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "T49.5 Probe");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1853M13P01")
            {
                Missing1PartNum.Add("1853M13P01"); // part 58
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1853M13P01");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Igniter Lead");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1374M12P01")
            {
                Missing1PartNum.Add("1374M12P01"); // part 59
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1374M12P01");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Spark Igniter");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-402-603-0")
            {
                Missing1PartNum.Add("340-402-603-0"); // part 60
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-402-603-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "VBV Actuator");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1324M12P10")
            {
                Missing1PartNum.Add("1324M12P10"); // part 61
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1324M12P10");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "VSV Actuator");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "1324M94P03")
            {
                Missing1PartNum.Add("1324M94P03"); // part 62
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "1324M94P03");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "HPT Thermocouple");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "340-400-203-0")
            {
                Missing1PartNum.Add("340-400-203-0"); // part 63
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "340-400-203-0");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Oil Anti Leak Valve");
            }

            else if (PlayerPrefs.GetString("Missing1PartNum" + i) == "AM2563-227")
            {
                Missing1PartNum.Add("AM2563-227"); // part 64
                PlayerPrefs.SetString("ReviewMissing1PartNum" + i, "AM2563-227");
                PlayerPrefs.SetString("ReviewMissing1Name" + i, "Engine Stand");
            }




    */
}
