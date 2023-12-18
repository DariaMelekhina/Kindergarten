using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarten_MAUI
{
    public class Logging  
    {
        private string _login;
        private string _password;
        private bool _isLogin;

        public Logging() 
        {
            _login = "";
            _password = "";
            _isLogin = false;
        }

        public string Login => _login;
        public string Password => _password;
        public string IsLogin => _password;
        public void SetPassword(string password) => _password = password;
        public void SetLogin(string login) => _login = login;
        public bool SendLoginRequest()
        {
            // TODO: Отправляем запрос на сервер
            if (true)
                _isLogin = true;

            return _isLogin;
        }
    }
}
