using Microsoft.Win32;


namespace Illallangi.PublicTransportVictoria.Settings
{
    public sealed class Setting
    {
        private const string DefaultUserId = @"XXXXXXX";
        private const string DefaultApiKey = @"XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
        private const string DefaultBaseUrl = @"https://timetableapi.ptv.vic.gov.au";
        private const string KeyName = @"Software\Illallangi Enterprises\Public Transport Victoria Client";

        public string UserId
        {
            get => this.UserId = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.UserId), DefaultUserId);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.UserId), value);
        }

        public string ApiKey
        {
            get => this.ApiKey = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.ApiKey), DefaultApiKey);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.ApiKey), value);
        }

        public string BaseUrl
        {
            get => this.BaseUrl = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.BaseUrl), DefaultBaseUrl);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.BaseUrl), value);
        }
    }
}
