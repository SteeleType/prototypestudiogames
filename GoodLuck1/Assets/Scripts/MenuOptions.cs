using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    public GameObject statsScreen;


    public bool isMenuOpen;

    public void Start()
    {
        isMenuOpen = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isMenuOpen = !isMenuOpen; 
            statsScreen.SetActive(isMenuOpen);
        }
    }
}