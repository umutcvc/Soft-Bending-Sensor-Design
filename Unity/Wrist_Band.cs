using System.Collections;
using UnityEngine;
using System.IO.Ports;
public class Wrist_Band : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM8", 115200); // PORTLARIN DATA AKTARMASINI BASLATIYOR
    public string receivedstring;
    public float sensitivity = 0.001f;
    public Transform AA, BB, CC, DD, EE, FF, GG, XX, YY, ZZ;

    public string[] datas;

    void Start()
    {
        data_stream.Open();
        data_stream.ReadTimeout = 50;
    }
    void Update()
    {
        receivedstring = data_stream.ReadLine();

        string[] datas = receivedstring.Split(',');

        int received_angle = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_2 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_3 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_4 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_5 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_6 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_7 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_8 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_9 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_10 = Mathf.RoundToInt(float.Parse(receivedstring));

   

        AA.transform.eulerAngles = new Vector3(received_angle, 0, 0);
        BB.transform.eulerAngles = new Vector3(received_angle_2*1.5f, 0, 0);
        CC.transform.eulerAngles = new Vector3(received_angle_3*2.5f, 0, 0);
        DD.transform.eulerAngles = new Vector3(received_angle_4*3.5f, 0, 0);
        EE.transform.eulerAngles = new Vector3(received_angle_5*4.5f, 0, 0);
        FF.transform.eulerAngles = new Vector3(received_angle_6*5.5f, 0, 0);
        GG.transform.eulerAngles = new Vector3(received_angle_7*6.5f, 0, 0);
        XX.transform.eulerAngles = new Vector3(received_angle_8*7.5f, 0, 0);
        YY.transform.eulerAngles = new Vector3(received_angle_9*8.5f, 0, 0);
        ZZ.transform.eulerAngles = new Vector3(received_angle_10*9.5f, 0, 0);

       

    }
}