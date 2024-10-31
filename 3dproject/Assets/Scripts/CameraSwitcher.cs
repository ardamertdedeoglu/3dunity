using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public List<Camera> cameras = new(); // kamera listesi oluþturduk
   
    private KeyCode[] keyBindings = //1den 0'a kadar tuþlarý içeren bir liste oluþturduk her eklenen kameradan indexine göre buradan atama yapacaðýz
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
        for (int i = 0; i < cameras.Count && i < keyBindings.Length; i++) //kamera listesini aþmadýkça ve tuþ limitini aþmadýkça kamera listesini gez
        {
            if (Input.GetKeyDown(keyBindings[i])) //kameranýn listedeki yerine göre 1'den baþlayarak aktive ediyoruz
            {
                ActivateCamera(i);
            }
        }
    }

    void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Count; i++) // kamera listesinde tek tek geziyoruz ve fonksiyon çaðýrýldýnda enable ediyoruz
        {
            cameras[i].enabled = (i == index);
        }
    }
}
