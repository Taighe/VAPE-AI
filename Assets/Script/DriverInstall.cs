using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VapeEvents;

public class DriverInstall : Action
{
    public Text computerText;
    [TextArea(3, 10)]
    public string driverInstall;

    public void IntallDriver()
    {
        computerText.text += driverInstall;
    }
}
