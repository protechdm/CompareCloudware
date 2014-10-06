namespace CompareCloudware.Web.Helpers
{
    using Castle.MicroKernel;
    using CompareCloudware.Web;
    using System;
    using System.ComponentModel;
    using System.Web.Mvc;

    public class CustomModelBinder : DefaultModelBinder
    {
        private readonly IFilteredModelBinder[] _filteredModelBinders;
        private readonly IKernel _kernel;

        public CustomModelBinder(IFilteredModelBinder[] filteredModelBinders)
        {
            this._filteredModelBinders = filteredModelBinders;
        }

        public CustomModelBinder(IKernel kernel)
        {
            this._kernel = kernel;
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return base.BindModel(controllerContext, bindingContext);
        }

        protected override void BindProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor)
        {
            string modelStateName = string.IsNullOrEmpty(bindingContext.ModelName) ? propertyDescriptor.Name : (bindingContext.ModelName + "." + propertyDescriptor.Name);
            if (propertyDescriptor.PropertyType == typeof(ICustomSession))
            {
                if (bindingContext.ModelState[modelStateName] == null)
                {
                    ICustomSession sessionValue = (ICustomSession) ((dynamic) controllerContext.Controller.ViewBag).CustomSession;
                    this.SetProperty(controllerContext, bindingContext, propertyDescriptor, sessionValue);
                }
                else
                {
                    base.BindProperty(controllerContext, bindingContext, propertyDescriptor);
                }
            }
            else
            {
                base.BindProperty(controllerContext, bindingContext, propertyDescriptor);
            }
        }

        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            ValueProviderResult req = bindingContext.ValueProvider.GetValue("req");
            object session = ((dynamic) controllerContext.Controller.ViewBag).CustomSession;
            try
            {
                return this._kernel.Resolve(modelType);
            }
            catch (Exception)
            {
                return base.CreateModel(controllerContext, bindingContext, modelType);
            }
        }

        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, object value)
        {
            string modelStateName = string.IsNullOrEmpty(bindingContext.ModelName) ? propertyDescriptor.Name : (bindingContext.ModelName + "." + propertyDescriptor.Name);
            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        }
    }
}

