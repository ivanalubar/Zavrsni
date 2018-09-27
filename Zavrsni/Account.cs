using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public class Account
    {
        //private string _email;
        private string _appKey;
        private string _appSecret;
        private string _accessToken;

        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

        public string AppKey
        {
            get{ return _appKey;}
            set { _appKey = value;}
        }

        public string AppSecret
        {
            get{return _appSecret; }
            set { _appSecret = value;}
        }

        public string AccessToken
        {
            get {return _accessToken;}
            set{ _accessToken = value; }
        }
        public Account(/*string e,*/ string appK, string appS,string AT)
        {
            //Email = e;
            AppKey = appK;
            AppSecret = appS;
            AccessToken = AT;
        }
        public Account()
        {
            ////Email = "null";
            AppKey = "null";
            AppSecret = "null";
            AccessToken = "null";
        }


    }
}
