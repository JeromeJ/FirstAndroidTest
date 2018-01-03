using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidExplorer : MonoBehaviour
{
    #region Public Members

    public Text debug;
    public GameObject player;

    #endregion

    #region Public void

    #endregion

    #region System

    protected void Awake()
    {
        Input.gyro.enabled = true;

        Input.location.Start();
    }

    //public void GetTouchCoụnt

    private void Update()
    {
        debug.text = "";

        debug.text += "Touch count: " + Input.touchCount + "\n";

        if (Input.touchCount > 0)
        {
            debug.text += "Position: " + Input.touches[0].position + "\n";
        }

        

        debug.text += "\n";

        debug.text += "Acceleration: " + Input.acceleration+ "\n";
        debug.text += "Compass:" + Input.compass.rawVector + "\n";

        debug.text += "\n";

        // Needs to be enabled first!!
        debug.text += "Gyro: " + Input.gyro.userAcceleration + "\n";
        debug.text += "Gyro attitude: " + Input.gyro.attitude+ "\n";

        debug.text += "\n";

        if (Input.location.status == LocationServiceStatus.Running)
        {
            debug.text += "Longitutde: " + Input.location.lastData.longitude + "\n";
            debug.text += "Latitude: " + Input.location.lastData.latitude + "\n";
        }
        else
            debug.text += "LocationService not running rn.\n";

        // Android asset toolkit (not free)
        // Android + profiler + wifi = happiness

        Debug.Log(player);

        try
        {
            player.transform.Translate(player.GetComponentInChildren<Camera>().transform.forward * (Input.touchCount) * 0.7f);
        }
        catch (System.Exception e)
        {
            debug.text += e;
        }
    }

    #endregion

    #region Class Methods

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
