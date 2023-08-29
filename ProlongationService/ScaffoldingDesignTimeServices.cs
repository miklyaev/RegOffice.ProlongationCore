﻿using EntityFrameworkCore.Scaffolding.Handlebars;
using HandlebarsDotNet;
using Humanizer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProlongationService
{
    /// <summary>
    /// Класс для кастомизации кода сгенерированного scaffold скриптом
    /// Убирает префикс Ro, т.к. таблицы в базе начинаются на ro_
    /// </summary>
    public class ScaffoldingDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            var options = ReverseEngineerOptions.DbContextAndEntities;
            services.AddHandlebarsScaffolding(options);

            Handlebars.RegisterHelper("ro-helper", AstralHbsHelper);

            services.AddHandlebarsTransformers2(
                entityTypeNameTransformer: n => ReplacePrefix("Ro", n),
                entityFileNameTransformer: n => ReplacePrefix("Ro", n),
                constructorTransformer: (e, p) => CreateEntityPropertyInfo(p, "Ro"),
                propertyTransformer: (e, p) => CreateEntityPropertyInfo(p, "Ro"),
                navPropertyTransformer: (e, p) => CreateEntityPropertyInfo(p, "Ro")
                );
        }

        private string ReplacePrefix(string prefix, string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Regex regex = new Regex("^" + prefix);
                return regex.Replace(input, "");
            }

            return input;
        }
        private EntityPropertyInfo CreateEntityPropertyInfo(EntityPropertyInfo p, string prefix)
        {
            if (p != null && p.PropertyType != null && p.PropertyName != null)
            {
                Regex regex = new Regex("^" + prefix);
                string typePrefix = regex.Replace(p.PropertyType, "");
                string namePrefix = regex.Replace(p.PropertyName, "");

                return new EntityPropertyInfo(typePrefix, namePrefix);
            }
            else
                return null;
        }
        private void AstralHbsHelper(EncodedTextWriter writer, Context context, Arguments arguments)
        {
            var parm = arguments[0] as string;
            Regex regex = new Regex("^Ro");
            string result = regex.Replace(parm, "");
            writer.Write(result.Pluralize());
        }
    }
}
