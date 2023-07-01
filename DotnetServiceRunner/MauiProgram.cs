namespace DotnetServiceRunner;

public static class MauiProgram
{
  /// <summary>
  /// Creates and configures a Maui application instance.
  /// </summary>
  /// <returns>The configured Maui application instance.</returns>
  public static MauiApp CreateMauiApp()
  {
    // Create a MauiApp builder & registers the various services, view models and views
    var builder = MauiApp
      .CreateBuilder()
      .UseMauiApp<App>()
      .ConfigureFonts()
      .RegisterAppServices()
      .RegisterViewModels()
      .RegisterViews();

    // Build and return the configured Maui application
    return builder.Build();
  }

  /// <summary>
  /// Configures the fonts used in the Maui application.
  /// </summary>
  /// <param name="mauiAppBuilder">The MauiAppBuilder instance.</param>
  /// <returns>The updated MauiAppBuilder instance.</returns>
  public static MauiAppBuilder ConfigureFonts(this MauiAppBuilder mauiAppBuilder)
  {
    // Configure the fonts using the provided MauiAppBuilder instance
    mauiAppBuilder.ConfigureFonts(fonts =>
    {
      // Add custom font files and their associated aliases
      fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
      fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    });

    // Return the updated MauiAppBuilder instance
    return mauiAppBuilder;
  }

  /// <summary>
  /// Registers application services with the Maui application.
  /// </summary>
  /// <param name="mauiAppBuilder">The MauiAppBuilder instance.</param>
  /// <returns>The updated MauiAppBuilder instance.</returns>
  public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
  {
    // Register application services using the provided MauiAppBuilder instance
    // TODO: mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();

    // Return the updated MauiAppBuilder instance
    return mauiAppBuilder;
  }

  /// <summary>
  /// Registers view models with the Maui application.
  /// </summary>
  /// <param name="mauiAppBuilder">The MauiAppBuilder instance.</param>
  /// <returns>The updated MauiAppBuilder instance.</returns>
  public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
  {
    // Register view models using the provided MauiAppBuilder instance
    mauiAppBuilder.Services.AddSingleton<Pages.MainPage>();

    // Return the updated MauiAppBuilder instance
    return mauiAppBuilder;
  }

  /// <summary>
  /// Registers views with the Maui application.
  /// </summary>
  /// <param name="mauiAppBuilder">The MauiAppBuilder instance.</param>
  /// <returns>The updated MauiAppBuilder instance.</returns>
  public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
  {
    // Register views using the provided MauiAppBuilder instance
    // TODO


    // Return the updated MauiAppBuilder instance
    return mauiAppBuilder;
  }
}