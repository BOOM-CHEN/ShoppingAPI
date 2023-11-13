using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Shopping.ShoppingAPI.Utils.Swagger
{

    /// <summary>
    /// 
    /// </summary>
    public class DefaultValueSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// swagger默认值
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema == null)
            {
                return;
            }
            var objectSceam = schema;
            foreach (var property in objectSceam.Properties)
            {
                if ((property.Value.Default == null || property.Value.Type == "string") && property.Key != "id")
                {
                    property.Value.Default = new OpenApiString("");
                }
            }
        }
    }
}
