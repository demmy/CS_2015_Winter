using Clinica.Model;

namespace Clinica.Interfaces
{
     interface IDepartment
    {
        void AddDoctor(Doctor doctor);
        void RemoveDoctor(Doctor doctor);
        void GetPay();
    }
}