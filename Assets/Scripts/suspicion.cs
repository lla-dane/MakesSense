using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class suspicion : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    public void Setsuspicion(int sus_value){
        slider.value = sus_value;
    }
}
