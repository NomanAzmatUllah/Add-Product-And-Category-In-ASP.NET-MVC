using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(addcategory_product.Startup))]
namespace addcategory_product
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
