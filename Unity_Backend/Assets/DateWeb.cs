using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DateWeb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(GetUsers());
        StartCoroutine(GetDate());
        StartCoroutine(loginData("aditya", "1234"));
    }

    IEnumerator GetDate()
    {
        using (UnityWebRequest www=UnityWebRequest.Get("http://localhost/Unity%20Backend/Date.php"))
        {
            yield return www.Send();
            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //Show result
                Debug.Log(www.downloadHandler.text);
                // Or Retrieve result as binary Data.
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/Unity%20Backend/GetUsers().php"))
        {
            yield return www.Send();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //Show result
                Debug.Log(www.downloadHandler.text);
                // Or Retrieve result as binary Data.
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator loginData(string username,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using(UnityWebRequest www=UnityWebRequest.Post("http://localhost/Unity%20Backend/login.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }


}
