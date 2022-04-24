using System.Collections.Generic;

namespace AppSettings.FeatureFlags {
  public interface IAppFeatures {
    IDictionary<string, bool> Flags { get; }
  }

  public class AppFeatures : IAppFeatures {
    private readonly IDictionary<string, bool> flags;

    public AppFeatures(IDictionary<string, bool> flags) {
      this.flags = flags;
    }

    public IDictionary<string, bool> Flags => this.flags;
  }
}
