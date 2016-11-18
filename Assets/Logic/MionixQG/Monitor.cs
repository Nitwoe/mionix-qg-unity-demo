using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSocketSharp;
using UnityEngine;

namespace Logic.MionixQG
{
    public class Monitor
    {
        public const string MIONIX_QG_WEBSOCKET_URI = @"ws://localhost:7681";

        protected static Monitor _instance;

        protected Monitor()
        { }

        public static Monitor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Monitor();
                }

                return _instance;
            }
        }

        public event EventHandler<CloseEventArgs> OnClose;
        public event EventHandler<ErrorEventArgs> OnError;
        public event EventHandler<EventArgs> OnOpen;
        public event EventHandler<BioMetricsEventArgs> OnBioMetrics;
        public event EventHandler<BioRawEventArgs> OnBioRaw;
        public event EventHandler<MouseMetricsEventArgs> OnMouseMetrics;
        
        protected WebSocket Socket;

        public void Connect()
        {
            Socket = new WebSocket(MIONIX_QG_WEBSOCKET_URI, "mionix-beta");

            Socket.OnOpen += Socket_OnOpen;
            Socket.OnError += Socket_OnError;
            Socket.OnMessage += Socket_OnMessage;
            Socket.OnClose += Socket_OnClose;

            Socket.Connect();
        }

        public void Disconnect()
        {
            Socket.Close();
        }

        void Socket_OnClose(object sender, CloseEventArgs e)
        {
            if(OnClose != null)
            {
                OnClose(this, e);
            }
        }

        void Socket_OnError(object sender, ErrorEventArgs e)
        {
            if (OnClose != null)
            {
                OnError(this, e);
            }
        }

        void Socket_OnOpen(object sender, EventArgs e)
        {
            if (OnClose != null)
            {
                OnOpen(this, e);
            }
        }

        void Socket_OnMessage(object sender, MessageEventArgs e)
        {
            var o = JsonUtility.FromJson<BaseMessage>(e.Data);
            
            switch(o.type)
            {
                case "bioMetrics":
                    if (OnBioMetrics != null)
                    {
                        OnBioMetrics(this, new BioMetricsEventArgs(JsonUtility.FromJson<BioMetrics>(e.Data)));
                    }
                    break;
                case "bioRaw": 
                    if(OnBioRaw != null)
                    {
                        OnBioRaw(this, new BioRawEventArgs(JsonUtility.FromJson<BioRaw>(e.Data)));
                    }
                    break;
                case "mouseMetrics":
                    if(OnMouseMetrics != null)
                    {
                        OnMouseMetrics(this, new MouseMetricsEventArgs(JsonUtility.FromJson<MouseMetrics>(e.Data)));
                    }
                    break;
                default:
                    throw new ArgumentException("Unexpected message type");
            }
        }
    }
}
