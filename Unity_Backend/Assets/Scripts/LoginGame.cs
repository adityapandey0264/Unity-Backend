using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginGame : MonoBehaviour
{

    public InputField NameInput;
    public InputField PassInput;
    public Button LoginButon;

    public GameObject loginPanel;
    public GameObject RegisterUserPanel;
    public bool isLoginScreen;
    // Start is called before the first frame update
    void Start()
    {
        isLoginScreen = true;
        //Using Lambda Expression
        LoginButon.onClick.AddListener(() =>
        {
            StartCoroutine(Main._Instance.web.loginData(NameInput.text, PassInput.text));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenRegisterUserScreen()
    {
        if(isLoginScreen)
        {
            loginPanel.SetActive(false);
            RegisterUserPanel.SetActive(true);
            isLoginScreen = false;

        }
    }
}
