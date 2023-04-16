using homeworkcsharp.Repository;
using homeworkcsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcsharp.Controllers
{
    class UserController
    {
        public System.Data.DataTable Index()
        {
            UserRepository repository = new UserRepository();
            return repository.ObtenerDatos();
        }

        public void Store(string name, int idNumber, string doctor, string date, string hour, string speciality)
        {

            UserRepository repository = new UserRepository();
            Models.User user = new Models.User();
            user.Name = name;
            user.IdNumber = idNumber;
            user.Doctor = doctor;
            user.DateTime = date;
            user.Hour = hour;
            user.Speciality = speciality;

            if (this.Validator(user))
                repository.InsertarRegistro(user);
            else
                System.Windows.Forms.MessageBox.Show("¡Hay errores en los datos, verifica e intenta nuevamente!");
        }

        public bool Validator(Models.User user)
        {


            if (user.Name == "" || user.IdNumber.ToString() == "" || user.Doctor == "" || user.DateTime == "" || user.Hour == "" || user.Speciality == "")
            {
                return false;

            }

            return true;

        }
    }
}
