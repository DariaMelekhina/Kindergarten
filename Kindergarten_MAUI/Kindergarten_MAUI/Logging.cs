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

        public Logging() 
        {
            _login = "";
            _password = "";
        }

        public string Login => _login;
        public string Password => _password;
        public string IsLogin => _password;
        public void SetPassword(string password) => _password = password;
        public void SetLogin(string login) => _login = login;
        public string SendLoginRequest()
        {
            string idParent = "-1";

            // TODO: Отправляем запрос на сервер
            if (false) // Если пришёл id меняем значение переменной
            {
                //idParent = {};
            }

            return idParent;
        }
    }
}
