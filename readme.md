# AppSettings.FeatureFlags

### What is AppSettings.FeatureFlags?
AppSettings.FeatureFlags is a very simple feature flag system using the standard dotnet configuration system using file appsettings.json file(s).

### Why would I use it?

You shouldn't. Seriously, use something better... but if you must you'd be using this if you want stupid simple feature flags controlled by appsettings.json settings.

### How do I use it?
Add the following to your appsettings.json file:

```json
  "Features": {
    "SuperAwesomeFeature1": true,
    "SnazzyFeature3": false
  }
```
### Issues?

If you have any issues please report it here.


