using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Fields;
using KATSU.Feature.Package.Helper;
using KATSU.Feature.Package.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.Diagnostics;
using Sitecore.ExperienceForms.Models;
using Sitecore.ExperienceForms.Processing;
using Sitecore.ExperienceForms.Processing.Actions;
using Sitecore.Globalization;
using Sitecore.Resources.Media;
using Sitecore.SecurityModel;

namespace KATSU.Feature.Package.SubmitActions.UploadPackage
{
    public class UploadPackage : SubmitActionBase<UploadPackageData>
    {
        private IContentRepository _contentRepository;
        private IContextRepository _contextRepository;
        private ILogRepository _logRepository;

        public UploadPackage(ISubmitActionData submitActionData) : base(submitActionData)
        {
        }

        protected override bool Execute(UploadPackageData data, FormSubmitContext formSubmitContext)
        {
            try
            {
                Assert.ArgumentNotNull(data, nameof(data));
                Assert.ArgumentNotNull(formSubmitContext, nameof(formSubmitContext));

                // Initialize services
                _contentRepository = (IContentRepository)DependencyResolver.Current.GetService(typeof(IContentRepository));
                _contextRepository = (IContextRepository)DependencyResolver.Current.GetService(typeof(IContextRepository));
                _logRepository = (ILogRepository)DependencyResolver.Current.GetService(typeof(ILogRepository));

                var fields = GetFormFields(data, formSubmitContext);

                Assert.IsNotNull(fields, nameof(fields));

                var values = fields.GetFieldValues();

                // Check if logo uploaded
                if (string.IsNullOrEmpty(values.File))
                {
                    SubmitActionData.ErrorMessage = Translate.Text("FileUploadRequired");
                    return false;
                }

                //TODO: Get Id from settings Item or web config.
                var parentItem = _contentRepository.GetItem<IPackagesFolder>(
                    new GetItemByPathOptions() { Path = "/sitecore/content/KATSU/Global/Packages Data" });

                // Get logo image 
                var packageFile = GetFile(values.File);

                var mediaItem = AddFile(packageFile, @"/sitecore/media library/Project/KATSU/Packages/" + values.PackageName,
                    values.PackageName);

                // New Entity
                var newItem = new Models.Package
                {
                    Name = values.PackageName,
                    PackageName = values.PackageName,
                    PackageIdentifier = values.PackageIdentifier,
                    PackageFile = new Glass.Mapper.Sc.Fields.File() { Id = new Guid(mediaItem.ID.ToString()), Src = mediaItem.MediaPath },
                };


                var createOptions = new CreateByModelOptions
                {
                    Parent = parentItem,
                    Model = newItem
                };

                using (new SecurityDisabler())
                {
                    try
                    {
                        _contentRepository.CreateItem<Models.Package>(createOptions);

                        // Set item to draft state
                        //var item = _contentRepository.GetItem<Item>(new GetItemByIdOptions
                        //{ Id = newItem.Id, Language = LanguageManager.GetLanguage("en") });
                        //_workflowEngine.ChangeWorkflowState(item, Settings.Workflows.GovernmentEntityApproval,
                        //    WorkflowStates.Draft);
                    }
                    catch (Exception ex)
                    {
                        SubmitActionData.ErrorMessage = ex.Message;
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                SubmitActionData.ErrorMessage = Translate.Text("ServerError");
                _logRepository.Error(ex.Message);
                return false;
            }
        }

        public string GetFile(string fileId)
        {
            var filePaths = Directory.GetFiles(@"C:\SitecoreFiles\", $"{fileId}.*");

            return filePaths.FirstOrDefault();
        }

        public MediaItem AddFile(string fileName, string sitecorePath, string mediaItemName)
        {
            Assert.ArgumentNotNullOrEmpty(fileName, nameof(fileName));

            // Create the options
            var options = new MediaCreatorOptions
            {
                FileBased = false,
                IncludeExtensionInItemName = true,
                OverwriteExisting = true,
                Versioned = false,
                Destination = sitecorePath + "/" + mediaItemName,
                Database = Sitecore.Context.Database
            };

            // Now create the file
            var creator = new MediaCreator();
            var mediaItem = creator.CreateFromFile(fileName, options);
            return mediaItem;
        }

        private PackageFormFields GetFormFields(UploadPackageData data, FormSubmitContext formSubmitContext)
        {
            Assert.ArgumentNotNull(data, nameof(data));
            Assert.ArgumentNotNull(formSubmitContext, nameof(formSubmitContext));

            return new PackageFormFields
            {
                PackageName = FieldHelper.GetFieldById(data.PackageNameFieldId, formSubmitContext.Fields),
                PackageIdentifier = FieldHelper.GetFieldById(data.PackageIdentifierFieldId, formSubmitContext.Fields),
                File = FieldHelper.GetFieldById(data.FileFieldId, formSubmitContext.Fields)
            };
        }

        internal class PackageFormFields
        {
            public IViewModel PackageName { get; set; }
            public IViewModel PackageIdentifier { get; set; }
            public IViewModel File { get; set; }

            public PackageFieldValues GetFieldValues()
            {
                return new PackageFieldValues
                {
                    PackageName = FieldHelper.GetValue(PackageName),
                    PackageIdentifier = FieldHelper.GetValue(PackageIdentifier),
                    File = FieldHelper.GetValue(File),
                };
            }
        }

        internal class PackageFieldValues
        {
            public string PackageName { get; set; }
            public string PackageIdentifier { get; set; }
            public string File { get; set; }
        }
    }
}
