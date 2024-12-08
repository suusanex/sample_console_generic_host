namespace sample_console_generic_host;
public class AppConfig
{
    /// <summary>
    /// UserSecretから読み込む
    /// </summary>
    public string Secret1 { get; set; }

    /// <summary>
    /// appsettings.jsonから読み込む
    /// </summary>
    public string Other1 { get; set; }

}
