using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TurnMeOn : MonoBehaviour
{
    public GameObject dog;
    
    [YarnCommand("SwitchOn")]
    public void SwitchOn()
    {
        dog.SetActive(true);
    }
}
