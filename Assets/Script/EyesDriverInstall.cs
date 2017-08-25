using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VapeEvents;

public class EyesDriverInstall : Action
{
    public Text computerText;

    public void IntallDriver()
    {
        computerText.text += "\nEyes Installed...\nPlease insert 'Ears Driver'";
    }
}
