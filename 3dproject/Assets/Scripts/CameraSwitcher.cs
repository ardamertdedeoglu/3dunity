using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public List<Camera> cameras = new(); // kamera listesi olu�turduk
   
    private KeyCode[] keyBindings = //1den 0'a kadar tu�lar� i�eren bir liste olu�turduk her eklenen kameradan indexine g�re buradan atama yapaca��z
    {
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3,
        KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6,
        KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9,
        KeyCode.Alpha0
    };
    
    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < cameras.Count && i < keyBindings.Length; i++) //kamera listesini a�mad�k�a ve tu� limitini a�mad�k�a kamera listesini gez
        {
            if (Input.GetKeyDown(keyBindings[i])) //kameran�n listedeki yerine g�re 1'den ba�layarak aktive ediyoruz
            {
                ActivateCamera(i);
            }
        }
    }

    void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Count; i++) // kamera listesinde tek tek geziyoruz ve fonksiyon �a��r�ld�nda enable ediyoruz
        {
            cameras[i].enabled = (i == index);
        }
    }
}
