using UnityEngine;
using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class PlayerControllerScript: MonoBehaviour
{

	// 1. Declare Variables
	Thread receiveThread; //1
	UdpClient client; //2
	int port; //3
    public static string text;


    public GameObject Player; //4
    string temp;


    float x;
	// 2. Initialize variables
	void Start () 
	{
		port = 5065; //1 
		InitUDP(); //4
	}

	// 3. InitUDP
	private void InitUDP()
	{
		print ("UDP Initialized");

		receiveThread = new Thread (new ThreadStart(ReceiveData)); //1 
		receiveThread.IsBackground = true; //2
		receiveThread.Start (); //3

	}

	// 4. Receive Data
	private void ReceiveData()
	{
		client = new UdpClient (port); //1
		while (true) //2
		{
			try
			{
				IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), port); //3
				byte[] data = client.Receive(ref anyIP); //4

				text = Encoding.UTF8.GetString(data); //5
                if (text == "left" && temp != text)
                {
                    //print(text);
                }
                else if (text == "right" && temp != text)
                {
                    //print(text);
                }
                else if(temp != text)
                {
                    //print("centre");
                }
                
                temp = text;
            } catch(Exception e)
			{
				print (e.ToString()); //7
			}
            
		}
	}


	// 6. Check for variable value, and make the Player Jump!
	void Update () 
	{
	}
}
