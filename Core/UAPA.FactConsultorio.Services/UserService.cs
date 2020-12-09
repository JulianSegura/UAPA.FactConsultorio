using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UAPA.FactConsultorio.Domain.DTOs;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Enums;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Services
{
    public class UserService
    {
        private IRepository<User> _usersRepo;
        private readonly IUnitOfWork _UoW;

        public UserService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _usersRepo = _UoW.UsersRepo;
        }

        public bool Add(User user)
        {
            try
            {
                user.UserName=user.UserName.ToUpper();
                user.Password = EncodeText(user.Password);
                _usersRepo.Add(user, LoggedUser.UserId);
                _UoW.Complete();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(User user)
        {
            try
            {
                _usersRepo.Update(user, LoggedUser.UserId);
                _UoW.Complete();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Login(LoginInfo login)
        {
            try
            {
                login.UserName = login.UserName.ToUpper();
                var user=_usersRepo.Get(u => u.UserName == login.UserName).FirstOrDefault();
                if (user != null && user.Enabled && user.Password == EncodeText(login.Password))
                {
                    LoggedUser.UserId = user.Id;
                    LoggedUser.Name = user.Name;
                    LoggedUser.Role = Convert.ToString((UserRoles)user.UserRole);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string EncodeText(string text)
        {
            byte[] textToEncodeBytes = ASCIIEncoding.ASCII.GetBytes(text);
            textToEncodeBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(textToEncodeBytes);
            string encodedPass = Encoding.ASCII.GetString(textToEncodeBytes);

            return encodedPass;
        }
    }
}
