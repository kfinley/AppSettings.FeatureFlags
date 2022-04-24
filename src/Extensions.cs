using System.Collections.Generic;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppSettings.FeatureFlags {
  public static class Extensions {

    public static IServiceCollection AddFeatureFlags(this IServiceCollection services,
                                                          IConfiguration config) {

      var flags = new Dictionary<string, bool>();

      foreach (var feature in config.GetSection("Features").GetChildren()) {
        flags.Add(feature.Key, bool.Parse(feature.Value));
      }

      services
        .AddTransient<IAppFeatures>((sc) => new AppFeatures(flags));

      return services;
    }
  }
}
