using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    public InputField nameField;
    public InputField PassField;
    public Button CreateButton;

    // Start is called before the first frame update
    void Start()
    {
        //using Lambda Expression
        CreateButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main._Instance.web.RegisterUser(nameField.text, PassField.text));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
