using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace System.Web.Mvc.Html
{
    public static partial class HtmlHelper
    {
        /// <summary>
        /// HTML Helper for rendering a DatePicker using 'Bootstrap.Datepicker' NuGet's package 1.3.0
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="self"></param>
        /// <param name="expression">Lambda that will evaluate the object.</param>
        /// <param name="DataAPIParameters">Custom data API parameters to use in the main input.</param>
        /// <returns></returns>
        public static MvcHtmlString DatePickerFor<TModel, TValue>
            (this HtmlHelper<TModel> self, Expression<Func<TModel, TValue>> expression, [Optional] params string[] DataAPIParameters)
        {
            // Get the Metadata from Model's DataAnnotations.
            var metadata = ModelMetadata.FromLambdaExpression(expression, self.ViewData);

            // Main input.
            var input = new TagBuilder("input");

            // Setting attributes.
            input.Attributes.Add("id", metadata.PropertyName);
            input.Attributes.Add("name", metadata.PropertyName);
            input.Attributes.Add("type", "text");
            input.Attributes.Add("data-provide", "datepicker"); // Bootstrap Markup API.
            input.AddCssClass("form-control"); // Bootstrap's 3.1.1 input CSS class.

            // Set Date's format according to the current culture from the HelperMethods.HTMLHelper package.
            if (Helpers.GetCurrentCulture() != null)
            {
                input.Attributes.Add("data-date-language", Helpers.GetCurrentCulture().ToString());
                input.Attributes.Add("data-date-format", Helpers.GetCurrentCulture().DateTimeFormat.ShortDatePattern.ToLower());
            }
            
            // Adds the validation properties from the HelperMethods.HTMLHelper package.
            Helpers.AddValidationProperties(self, expression, input);

            // Set the maxlength to 10.
            input.Attributes.Add("maxlength", "10");

            // Adds a mask in the ##/##/#### pattern.
            input.Attributes.Add("onkeypress", "format('##/##/####', this); function format(mascara, documento) { var i = documento.value.length; var saida = mascara.substring(0, 1); var texto = mascara.substring(i); if (texto.substring(0, 1) != saida) { documento.value += texto.substring(0, 1); } }");

            // Script to allow the user input only numbers. Will be loaded when DOM is ready.
            var allowOnlyNumbersScript = new TagBuilder("script");

            allowOnlyNumbersScript.InnerHtml = "$(document).ready(function() { onlyNumbers($('#" + metadata.PropertyName + "') ) }); function onlyNumbers(e) { e.keydown(function (e) { if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 || e.keyCode == 65 && e.ctrlKey === true || e.keyCode >= 35 && e.keyCode <= 39) { return } if ((e.shiftKey || e.keyCode < 48 || e.keyCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) { e.preventDefault() } }) }";

            // If the current Model's value is not null, set the input's value to correspond the call. If it is, set to the current date.
            if (metadata.Model != null)
            {
                input.Attributes.Add("value", ((DateTime)metadata.Model).ToShortDateString());
            }
            else
            {
                input.Attributes.Add("value", DateTime.Now.ToShortDateString());
            }

            // Datepicker API custom parameters specified optionally by the user.
            foreach (var p in DataAPIParameters)
            {
                input.Attributes.Add("data-date-" + p.Split('=')[0], p.Split('=')[1]);
            }

            return new MvcHtmlString(input.ToString() + allowOnlyNumbersScript.ToString());
        }
    }
}