namespace FlintCli.Contracts
{
    public interface IPlugin
    {
        PluginInfo GetPluginInfo();
        string Execute(string[] args);
    }
}
