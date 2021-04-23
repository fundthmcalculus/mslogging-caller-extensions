using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace MSLogging.Extensions.Caller
{
    public static class LoggerMethodExtensions
    {
        public static void Debug(this ILogger self, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, formattableString,null,null, lineNumber, caller, filePath);

        public static void Debug(this ILogger self,FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, formattableString,null,properties, lineNumber, caller, filePath);
        public static void Debug(this ILogger self,Exception exception, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, null,exception,null, lineNumber, caller, filePath);
        public static void Debug(this ILogger self,Exception exception, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, formattableString,exception,null, lineNumber, caller, filePath);
        public static void Debug(this ILogger self,Exception exception, FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, formattableString,exception,properties, lineNumber, caller, filePath);
        public static void DebugDump(this ILogger self,string label, object obj, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Debug, Serialize(label, obj),null,null, lineNumber, caller, filePath);


        public static void Info(this ILogger self,FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, formattableString,null,null, lineNumber, caller, filePath);
        public static void Info(this ILogger self,FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, formattableString,null,properties, lineNumber, caller, filePath);
        public static void Info(this ILogger self,Exception exception, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, null,exception,null, lineNumber, caller, filePath);
        public static void Info(this ILogger self,Exception exception, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, formattableString,exception,null, lineNumber, caller, filePath);
        public static void Info(this ILogger self,Exception exception, FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, formattableString,exception,properties, lineNumber, caller, filePath);
        public static void InfoDump(this ILogger self,string label, object obj, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Information, Serialize(label, obj),null,null, lineNumber, caller, filePath);


        public static void Warning(this ILogger self,FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, formattableString,null,null, lineNumber, caller, filePath);
        public static void Warning(this ILogger self,FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, formattableString,null,properties, lineNumber, caller, filePath);
        public static void Warning(this ILogger self,Exception exception, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, null,exception,null, lineNumber, caller, filePath);
        public static void Warning(this ILogger self,Exception exception, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, formattableString,exception,null, lineNumber, caller, filePath);
        public static void Warning(this ILogger self,Exception exception, FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, formattableString,exception,properties, lineNumber, caller, filePath);
        public static void WarningDump(this ILogger self,string label, object obj, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Warning, Serialize(label, obj),null,null, lineNumber, caller, filePath);


        public static void Error(this ILogger self,FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, formattableString,null,null, lineNumber, caller, filePath);
        public static void Error(this ILogger self,FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, formattableString,null,properties, lineNumber, caller, filePath);
        public static void Error(this ILogger self,Exception exception, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, null,exception,null, lineNumber, caller, filePath);
        public static void Error(this ILogger self,Exception exception, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, formattableString,exception,null, lineNumber, caller, filePath);
        public static void Error(this ILogger self,Exception exception, FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, formattableString,exception,properties, lineNumber, caller, filePath);
        public static void ErrorDump(this ILogger self,string label, object obj, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Error, Serialize(label, obj),null,null, lineNumber, caller, filePath);


        public static void Critical(this ILogger self,FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, formattableString,null,null, lineNumber, caller, filePath);
        public static void Critical(this ILogger self,FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, formattableString,null,properties, lineNumber, caller, filePath);
        public static void Critical(this ILogger self,Exception exception, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, null,exception,null, lineNumber, caller, filePath);
        public static void Critical(this ILogger self,Exception exception, FormattableString formattableString, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, formattableString,exception,null, lineNumber, caller, filePath);
        public static void Critical(this ILogger self,Exception exception, FormattableString formattableString, IDictionary<string, object> properties, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, formattableString,exception,properties, lineNumber, caller, filePath);
        public static void Critical(this ILogger self,string label, object obj, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "", [CallerFilePath] string filePath = "")
            => Log(self, LogLevel.Critical, Serialize(label, obj),null,null, lineNumber, caller, filePath);
        
        private static void Log(
            ILogger logger,
            LogLevel level,
            FormattableString formattableString,
            Exception ex,
            IDictionary<string, object> properties,
            int lineNumber,
            string caller,
            string filePath
        )
        {
            var scopeProperties = new Dictionary<string, object>(properties ?? new Dictionary<string, object>())
            {
                ["Line"] = lineNumber,
                ["Caller"] = caller,
                ["FilePath"] = filePath,
                ["FileName"] = GetFileNameSafe(filePath)
            };
            using (logger.BeginScope(scopeProperties))
            {
                if (!logger.IsEnabled(level)) return;
                logger.Log(level, new EventId(),formattableString?.ToString(),ex, (s, exception) => $"{s}\n{ex}");
            }
        }
        
        private static string GetFileNameSafe(string fileName)
        {
            try
            {
                return System.IO.Path.GetFileNameWithoutExtension(fileName);
            }
            catch
            {
                return fileName;
            }
        }
        
        private static FormattableString Serialize(string label, object obj)
        {
            if (obj == null)
                return $"{label}";

            try
            {
                var jsonStr = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    PreserveReferencesHandling = PreserveReferencesHandling.None,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter { NamingStrategy = new CamelCaseNamingStrategy()}
                    }
                });
                return $"{label}\n{jsonStr}";
            }
            catch (Exception e)
            {
                var json = new JObject
                {
                    { "Type", "Error" },
                    { "Message", new JObject
                        {
                            {"Reason", e.ToString()},
                            {"Message", $"Serialization of object with {obj.GetType().FullName} type failed"}
                        }
                    }
                };
                return $"{label} {json.ToString(Formatting.None)}";
            }
        }
    }
}