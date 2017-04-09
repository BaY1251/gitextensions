using EnvDTE;
using EnvDTE80;
using GitPluginShared.Git;

namespace GitPluginShared.Commands
{
    public abstract class CommandBase
    {
        abstract public void OnCommand(DTE2 application, OutputWindowPane pane);

        abstract public bool IsEnabled(DTE2 application);

        protected static void RunGitEx(string command, string filename, string[] arguments = null)
        {
            GitCommands.RunGitEx(command, filename, arguments);
        }

        public bool RunForSelection { get; set; }
    }
}