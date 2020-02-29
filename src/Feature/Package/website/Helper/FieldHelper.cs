using Sitecore.ExperienceForms.Data.Entities;
using Sitecore.ExperienceForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KATSU.Feature.Package.Helper
{
    public class FieldHelper
    {
        public static IViewModel GetFieldById(Guid id, IList<IViewModel> fields)
        {
            return fields.FirstOrDefault(f => Guid.Parse(f.ItemId) == id);
        }

        public static IViewModel GetFieldByName(string fieldName, IList<IViewModel> fields)
        {
            return fields.FirstOrDefault(f => f.Name == fieldName);
        }

        public static string GetValue(object field)
        {
            // Property Type 
            var value = field?.GetType().GetProperty("Value");
            var type = value?.PropertyType;
            if (type == typeof(List<string>))
            {
                return ((List<string>) value.GetValue(field, null))?.FirstOrDefault();
            }
            else if (type == typeof(List<StoredFileInfo>))
            {
                return ((List<StoredFileInfo>) value.GetValue(field, null))?.FirstOrDefault()?.FileId.ToString();
            }
            else if (type != null)
            {
                return value.GetValue(field, null)?.ToString() ?? string.Empty;
            }

            return string.Empty;
        }

        public static List<string> GetList(object field)
        {
            // Property Type 
            var value = field?.GetType().GetProperty("Value");
            var type = value?.PropertyType;
            if (type == typeof(List<string>))
            {
                return ((List<string>) value.GetValue(field, null));
            }

            return new List<string>();
        }

        public static string GetCountryCode(object field)
        {
            // Property Type 
            var value = field?.GetType().GetProperty("Value");
            var type = value?.PropertyType;
            if (type == typeof(List<string>))
            {
                return ((List<string>) value.GetValue(field, null))?.FirstOrDefault();
            }

            return string.Empty;
        }

        public static string GetAreaCode(object field)
        {
            // Property Type 
            var value = field?.GetType().GetProperty("AreaCode");

            if (value != null) return value.GetValue(field, null)?.ToString() ?? string.Empty;

            return string.Empty;
        }

        public static string GetPhoneNumber(object field)
        {
            // Property Type 
            var value = field?.GetType().GetProperty("PhoneNumber");

            if (value != null) return value.GetValue(field, null)?.ToString() ?? string.Empty;

            return string.Empty;
        }
    }
}