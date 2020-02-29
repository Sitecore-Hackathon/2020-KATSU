using KATSU.Feature.Package.Helper;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using Sitecore.Diagnostics;
using Sitecore.ExperienceForms.Models;
using Sitecore.ExperienceForms.Processing;
using Sitecore.ExperienceForms.Processing.Actions;

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
            //try
            //{
                //Assert.ArgumentNotNull(data, nameof(data));
                //Assert.ArgumentNotNull(formSubmitContext, nameof(formSubmitContext));

                //// Initialize services
                //_contentRepository = (IContentRepository)DependencyResolver.Current.GetService(typeof(IContentRepository));
                //_contextRepository = (IContextRepository)DependencyResolver.Current.GetService(typeof(IContextRepository));
                //_logRepository = (ILogRepository)DependencyResolver.Current.GetService(typeof(ILogRepository));

                //var fields = GetFormFields(data, formSubmitContext);

                //Assert.IsNotNull(fields, nameof(fields));

                //var values = fields.GetFieldValues();

                //// Check if logo uploaded
                //if (string.IsNullOrEmpty(values.File))
                //{
                //    SubmitActionData.ErrorMessage = Translate.Text("FileUploadRequired");
                //    return false;
                //}

                ////TODO: Get Id from settings Item or web config.
                //var parentItem = _contentRepository.GetItem(
                //    new GetItemByIdOptions { Id = new Guid("{CCB6285C-0932-4A3C-8CAB-4692652EED18}") });

                //// Get logo image 
                //var imageFile = GetFile(values.Logo);

                //var mediaItem = AddFile(imageFile, @"/sitecore/media library/Project/PSGN/Government Entity Logos",
                //    values.NameEn);

                //// New Entity
                //var newItem = new EntityDetails
                //{
                //    Name = values.NameEn,
                //    NameAr = values.NameAr,
                //    NameEn = values.NameEn,
                //    EstablishmentDate = DateTime.Parse(values.EstablishmentDate),
                //    Logo = new Image() { MediaId = new Guid(mediaItem.ID.ToString()) },
                //    Language = LanguageManager.GetLanguage("en")
                //};


                //var createOptions = new CreateByModelOptions
                //{
                //    Parent = parentItem,
                //    Model = newItem
                //};

                //using (new SecurityDisabler())
                //{
                //    try
                //    {
                //        _contentRepository.CreateItem<EntityDetails>(createOptions);
                //        HttpContext.Current.Session["itemId"] = newItem.Id.ToString();

                //        // Set item to draft state
                //        var item = _contentRepository.GetItem<Item>(new GetItemByIdOptions
                //        { Id = newItem.Id, Language = LanguageManager.GetLanguage("en") });
                //        _workflowEngine.ChangeWorkflowState(item, Settings.Workflows.GovernmentEntityApproval,
                //            WorkflowStates.Draft);
                //    }
                //    catch (Exception)
                //    {
                //        SubmitActionData.ErrorMessage = Translate.Text("DuplicateEntityName");
                //        return false;
                //    }
                //}

                return true;
            //}
            //catch (Exception ex)
            //{
            //    SubmitActionData.ErrorMessage = Translate.Text("ServerError");
            //    _logRepository.Error(ex.Message);
            //    return false;
            //}
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
