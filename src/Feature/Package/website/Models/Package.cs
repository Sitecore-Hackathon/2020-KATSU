using System;
using System.Collections;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using KATSU.Foundation.Enumeration.Models;
using Sitecore.Globalization;

namespace KATSU.Feature.Package.Models
{
    public class Package : IPackageGlassBase
    {
        public virtual Guid Id { get; set; }
        public virtual Language Language { get; set; }
        public virtual int Version { get; set; }
        public virtual IEnumerable BaseTemplateIds { get; set; }
        public virtual string TemplateName { get; set; }
        public virtual Guid TemplateId { get; set; }
        public virtual string Name { get; set; }
        public virtual string PackageName { get; set; }
        public virtual string PackageIdentifier { get; set; }
        public virtual File PackageFile { get; set; }
    }
}
