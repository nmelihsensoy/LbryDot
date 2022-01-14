using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Validation;
using FluentValidation.Results;

namespace BusinessLogicLayer.Services
{
    public class SettingsService : Abstract.ServiceBase
    {
        public SettingsService(CustomAppContext appContext) : base(appContext)
        {
        }

        public void ChangeSettings(SettingsModel Settings)
        {
            SettingsValidator validator = new SettingsValidator();
            ValidationResult results = validator.Validate(Settings);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            var output = _appContext.getUoW().SettingsRepository.UpdateSettings(Settings);
            _appContext.getUoW().Commit();

            if (output != 1)
            {
                throw new Exception("Settings Error");
            }
        }

        public SettingsModel GetCurrentSettings()
        {
            var output = _appContext.getUoW().SettingsRepository.GetSettings();
            _appContext.getUoW().Commit();

            return output;
        }

    }
}
