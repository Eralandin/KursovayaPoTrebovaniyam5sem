using KursovayaPoTrebovaniyam5sem.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaPoTrebovaniyam5sem.Presenter
{
    public class AuthorizationPresenter
    {
        //сделать подключение к БД
        private readonly IAuth _view;
        public AuthorizationPresenter(IAuth view) 
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LoginAttempt += this.LoginAttempt;
        }
        public void LoginAttempt(object sender, EventArgs e)
        {
            List<string> loginPass = _view.GetLoginPassword();
            try
            {

            }
            catch (Exception ex)
            {
                _view.Message("Непредвиденная ошибка! \n" + ex.Message);
            }
        }
    }
}
