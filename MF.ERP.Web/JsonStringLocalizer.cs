using Microsoft.Extensions.Localization;
using Newtonsoft.Json;

namespace MF.ERP.Web
{
    public class JsonStringLocalizer : IStringLocalizer
    {
        private JsonSerializer _jsonSerializer =new();
        public LocalizedString this[string name]
        {
            get
            {
                var value = GetString(name);
                return new LocalizedString(name, value);
            }
        }

        public LocalizedString this[string name, params object[] arguments]
        {
            get
            {
                var actualValue = this[name];
                return !actualValue.ResourceNotFound ?
                    new LocalizedString(name, String.Format(actualValue.Value, arguments)) : actualValue;
            }
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            string filePath =  $"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json";
            using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using StreamReader streamReader = new(stream);
            using JsonTextReader reader = new(streamReader);
            while (reader.Read())
            {
                if (reader.TokenType != JsonToken.PropertyName)
                    continue;
                var key = reader.Value as string;
                reader.Read();
                var value = _jsonSerializer.Deserialize<string>(reader);
                yield return new LocalizedString(key, value);
                 
            }
        }
        private string GetString(string key)
        {
            string filePath = Path.Combine($"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json");
            string fullFilePath = Path.GetFullPath(filePath);
            if (File.Exists(fullFilePath))
            {
                var result = GetValueFromJson(key, fullFilePath);
                return result;
            }
            return string.Empty;
        }
        private string GetValueFromJson(string propertyName, string filePath)
        {
            if (string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(filePath))
                return string.Empty;
            using FileStream stream = new(filePath,FileMode.Open,FileAccess.Read,FileShare.Read);
            using StreamReader streamReader = new(stream);
            using JsonTextReader reader = new(streamReader);
            while (reader.Read())
            {
                if (reader.TokenType==JsonToken.PropertyName&&reader.Value as string==propertyName)
                {
                    reader.Read();
                    return _jsonSerializer.Deserialize<string>(reader);
                }
            }
            return string.Empty;
        }
    }
}
