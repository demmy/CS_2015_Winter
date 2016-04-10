using System;
using EF_Repository.Model.Interfaces;

namespace WinFormsNoDevExp.Class.Interface
{
    interface IService
    {
        Array Pves();
        Array Pvps();
        Array Winners();
        IPlayer CheckingValidateUser(string login, string password);
        void CreatePlayer(string login, string password, string email, bool checkEmail);
        Array PlayersWithValidEmails();
        Array TopPlayersByLongestPassword();
        Array TopTransactionsBySum();
        Array PlayersOrderByDate();
        Array TransactionsOrderByDate();
    }
}
