using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Shopping.ShoppingAPI.Utils.Swagger
{
    public class DefaultValueSchemaFilter : ISchemaFilter
    {
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
