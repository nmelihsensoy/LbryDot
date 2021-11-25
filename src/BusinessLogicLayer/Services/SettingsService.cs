using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class SettingsService : Abstract.ServiceBase
    {
        public SettingsService(CustomAppContext appContext) : base(appContext)
        {
        }

        public void ChangeSettings(SettingsModel staff)
        {
            var output = _appContext.getUoW().SettingsRepository.UpdateSettings(staff);
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
