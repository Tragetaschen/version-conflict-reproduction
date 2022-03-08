using First;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Second;
public class Class
{
    public static void M()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddDbContext<MyContext>(options =>
            options.UseNpgsql("")
        );
    }
}
