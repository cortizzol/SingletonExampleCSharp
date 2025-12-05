using System;

class AppConfig
{
    private static AppConfig _instance;

    public string AppName { get; set; }
    public float AppVersion { get; set; }

    private AppConfig()
    {
        AppName = "Some App";
        AppVersion = 1.0f;
    }

    public AppConfig SetNewName(string AppName)
    {
        this.AppName = AppName;

        return this;
    }

    public AppConfig SetNewVersion(float AppVersion)
    {
        this.AppVersion = AppVersion;

        return this;
    }

    public static AppConfig GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AppConfig();
        }

        return _instance;
    }
}

class Program
{
    static void Main()
    {
        AppConfig app = AppConfig.GetInstance();

        Console.WriteLine($"An old name: {app.AppName}");
        Console.WriteLine($"An old version: {app.AppVersion}");

        var newName = app.SetNewName("Other name");
        var newVersion = app.SetNewVersion(1.1f);

        Console.WriteLine(" ");

        Console.WriteLine($"A new name: {app.AppName}");
        Console.WriteLine($"A new version: {app.AppVersion}");

    }
}