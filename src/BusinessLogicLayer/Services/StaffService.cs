using BusinessLogicLayer.Validation;
using Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StaffService : Abstract.ServiceBase
    {
        public StaffService(CustomAppContext appContext) : base(appContext)
        {
        }

        private void ApplyMd5Hashing(ref LoginModel Model)
        {
            if (!String.IsNullOrEmpty(Model.Password))
            {
                Model.Password = Helpers.MD5Hash(Model.Password, Helpers.GetEncryptionConfig());
            }
        }

        private void ApplyMd5Hashing(ref StaffModel Model)
        {
            if (!String.IsNullOrEmpty(Model.staff_password))
            {
                Model.staff_password = Helpers.MD5Hash(Model.staff_password, Helpers.GetEncryptionConfig());
            }
        }

        public void AddStaff(StaffModel Staff)
        {
            StaffValidator validator = new StaffValidator();
            ValidationResult results = validator.Validate(Staff);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Staff);
            var output = _appContext.getUoW().StaffRepository.Add(Staff);
            _appContext.getUoW().Commit();

            if (output != 1)
            {
                throw new Exception("Error");
            }
        }

        public List<StaffModel> GetAllStaff()
        {
            var output = _appContext.getUoW().StaffRepository.GetAllWithoutAdmin().ToList();
            _appContext.getUoW().Commit();

            return output;
        }

        public StaffModel GetStaffById(int Id)
        {
            var output = _appContext.getUoW().StaffRepository.GetById(Id);
            output.staff_password = "";
            _appContext.getUoW().Commit();

            return output;
        }

        public void DeleteStaff(StaffModel Staff)
        {
            var output = _appContext.getUoW().StaffRepository.Delete(Staff);
            _appContext.getUoW().Commit();
        }

        public void UpdateStaff(StaffModel Staff)
        {    
            StaffValidator validator = new StaffValidator();
            ValidationResult results = validator.Validate(Staff);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Staff);
            var output = _appContext.getUoW().StaffRepository.Update(Staff);
            _appContext.getUoW().Commit();

            if (output != 1)
            {
                throw new Exception("Error");
            }
        }

        public void UpdateAdmin(StaffModel Staff)
        {
            ApplyMd5Hashing(ref Staff);
            var output = _appContext.getUoW().StaffRepository.Update(Staff);
            _appContext.getUoW().Commit();

            if (output != 1)
            {
                throw new Exception("Error");
            }
        }

        public StaffModel LoginStaff(LoginModel Credential)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult results = validator.Validate(Credential);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Credential);
            return _appContext.getUoW().StaffRepository.LoginStaff(Credential);
        }

        public int GetStaffCount()
        {
            var output = _appContext.getUoW().StaffRepository.GetCount();
            _appContext.getUoW().Commit();

            return output;
        }

    }
}
