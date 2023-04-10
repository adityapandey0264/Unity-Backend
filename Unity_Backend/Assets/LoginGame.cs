using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginGame : MonoBehaviour
{

    public InputField NameInput;
    public InputField PassInput;
    public Button LoginButon;
    // Start is called before the first frame update
    void Start()
    {
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
    public void logintoGame()
    {

    }
}
