using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponToggle : MonoBehaviour
{
    private int toggleCount = 0;

    private void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++ )
        {
            // Switch of all weapons but the first
            if (i != 0)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle weapons
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.GetChild(toggleCount).gameObject.SetActive(false);
            toggleCount++;

            if (toggleCount > gameObject.transform.childCount-1)
                toggleCount = 0;

            Debug.Log("");
            gameObject.transform.GetChild(toggleCount).gameObject.SetActive(true);
        }
    }
}
