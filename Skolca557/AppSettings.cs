using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Skolca557
{
    internal class AppSettings
    {
        private static AppSettings? _instance;
        private Dictionary<string, object?> _Settings = new Dictionary<string, object?>();

        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppSettings();

                return _instance;
            }
        }

        private AppSettings() {}

        public void SetSetting(string k, object? v) => _Settings[k] = v;
        public object? GetSetting(string k) => _Settings[k];
        public T? GetSetting<T>(string k) => (T?)_Settings[k];

        public string AsJSON() => JsonConvert.SerializeObject(_Settings);
        public void LoadJSON(string json)
        {
            var dict = JsonConvert.DeserializeObject<Dictionary<string, object?>>(json);
            if (dict == null)
                throw new ApplicationException("Data is not a json string!");

            _Settings = dict;
        }

        public void PrintSettings() => Console.WriteLine(AsJSON());
    }
}
